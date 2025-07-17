using Koshenya.Core.States.Parameters;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Koshenya.Core
{
    public sealed class CharacterConfiguration
    {
        private static readonly string _parentDirectory;

        static CharacterConfiguration()
        {
            _parentDirectory = $"{Directory.GetCurrentDirectory()}\\Assets";
        }

        [XmlIgnore]
        public string Name { get; set; }
        public Animation[] Animations { get; set; }
        public Sound[] Sounds { get; set; }
        [XmlArrayItem(typeof(IdleStateParameters))]
        [XmlArrayItem(typeof(MovementStateParameters))]
        [XmlArrayItem(typeof(PunchStateParameters))]
        [XmlArrayItem(typeof(SleepStateParameters))]
        [XmlArrayItem(typeof(DragStateParameters))]
        public StateParameters[] States { get; set; }

        public static void Save(CharacterConfiguration config, bool copyResources = false)
        {
            if (!Directory.Exists(_parentDirectory))
                Directory.CreateDirectory(_parentDirectory);

            if (string.IsNullOrEmpty(config.Name))
                throw new ArgumentNullException(nameof(config.Name), $"Bad name: {config.Name}");

            string characterDirectory = $"{_parentDirectory}\\{config.Name}";

            if (Directory.Exists(characterDirectory))
                throw new ArgumentException($"Character with name {config.Name} alredy exists");

            Directory.CreateDirectory(characterDirectory);

            if (copyResources)
            {
                Directory.CreateDirectory($"{characterDirectory}\\Animations");
                Directory.CreateDirectory($"{characterDirectory}\\Sounds");

                foreach (var animation in config.Animations)
                {
                    Directory.CreateDirectory($"{characterDirectory}\\Animations\\{animation.Name}");

                    string[] frames = Directory.GetFiles(animation.Source);

                    for (int j = 0; j < frames.Length; j++)
                    {
                        File.Copy(frames[j], $"{characterDirectory}\\Animations\\{animation.Name}\\{frames[j].Substring(frames[j].LastIndexOf("\\") + 1)}");
                    }

                    animation.Source = $"{characterDirectory}\\Animations\\{animation.Name}";
                }
                foreach (var sound in config.Sounds)
                {
                    File.Copy(sound.Source, $"{characterDirectory}\\Sounds\\{sound.Name}.wav");

                    sound.Source = $"{characterDirectory}\\Sounds\\{sound.Name}.wav";
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(CharacterConfiguration));

            using (TextWriter writter = new StreamWriter($"{characterDirectory}\\.conf"))
            {
                serializer.Serialize(writter, config);
            }
        }

        public static CharacterConfiguration Read(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CharacterConfiguration));
            CharacterConfiguration config;

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                config = (CharacterConfiguration)serializer.Deserialize(stream);
            }

            config.Name = Directory.GetParent(path).Name;

            return config;
        }

        public sealed class Animation
        {
            public string Name { get; set; }
            public string Source { get; set; }
            public int FrameRate { get; set; }
            public bool IsReflected { get; set; }
            public bool IsReverse { get; set; }
        }

        public sealed class Sound
        {
            public string Name { get; set; }
            public string Source { get; set; }
        }
    }
}
