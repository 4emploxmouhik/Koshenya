using Koshenya.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Koshenya.Core.Characters.Cat
{
    internal class CatAssets : ICharacterAssets
    {
        private readonly string _animationsPath;
        private readonly string _soundsPath;

        private bool _isInitialized;

        public CatAssets(string color)
        {
            _animationsPath = $"{Directory.GetCurrentDirectory()}\\Assets\\Cat\\Animations\\{color}";
            _soundsPath = $"{Directory.GetCurrentDirectory()}\\Assets\\Cat\\Sounds";

            Animations = new List<Animation>();
            Clips = new List<AnimationClip>();
            Sounds = new Dictionary<string, string>();

            _isInitialized = false;

            CatColor = color;
        }

        public List<Animation> Animations { get; }
        public List<AnimationClip> Clips { get; }
        public Dictionary<string, string> Sounds { get; }
        public bool IsInitialized => _isInitialized;
        public string CatColor { get; }

        public void Initialize()
        {
            Animations.Clear();
            Clips.Clear();
            Sounds.Clear();

            Animations.Add(new Animation("Idle", Animation.Load($"{_animationsPath}\\idle"), 24));

            string[] directions = { "n", "nw", "w", "sw", "s" };
            string[] speeds = Enum.GetNames(typeof(Movement.Speeds));

            for (int i = 1; i < speeds.Length; i++)
            {
                for (int j = 0; j < directions.Length; j++)
                {
                    Animations.Add(new Animation(
                        name: $"{speeds[i]}-{Movement.GetDirectionByShortName(directions[j])}",
                        frames: Animation.Load($"{_animationsPath}\\{speeds[i]}\\{directions[j]}"),
                        frameRate: i == 1 ? 12 : 24));
                }

                Animations.Add(new Animation(
                        name: $"{speeds[i]}-{Movement.GetDirectionByShortName("se")}",
                        frames: Animation.Load($"{_animationsPath}\\{speeds[i]}\\sw", true, false),
                        frameRate: i == 1 ? 12 : 24));
                Animations.Add(new Animation(
                        name: $"{speeds[i]}-{Movement.GetDirectionByShortName("e")}",
                        frames: Animation.Load($"{_animationsPath}\\{speeds[i]}\\w", true, false),
                        frameRate: i == 1 ? 12 : 24));
                Animations.Add(new Animation(
                        name: $"{speeds[i]}-{Movement.GetDirectionByShortName("ne")}",
                        frames: Animation.Load($"{_animationsPath}\\{speeds[i]}\\nw", true, false),
                        frameRate: i == 1 ? 12 : 24));
            }

            Animations.Add(new Animation("Blink", Animation.Load($"{_animationsPath}\\blink"), 12));
            Animations.Add(new Animation("LookAround", Animation.Load($"{_animationsPath}\\look-around"), 10));
            Animations.Add(new Animation("Sleep", Animation.Load($"{_animationsPath}\\sleep"), 5));
            Animations.Add(new Animation("Laydown", Animation.Load($"{_animationsPath}\\laydown"), 10));
            Animations.Add(new Animation("Standup", Animation.Load($"{_animationsPath}\\laydown", false, true), 10));
            Animations.Add(new Animation("Meow", Animation.Load($"{_animationsPath}\\meow"), 12));
            Animations.Add(new Animation("Hisses", Animation.Load($"{_animationsPath}\\hisses"), 12));
            Animations.Add(new Animation("Dragging", Animation.Load($"{_animationsPath}\\dragging"), 24));
            Animations.Add(new Animation("DraggingSleep", Animation.Load($"{_animationsPath}\\dragging-sleep"), 5));

            AnimationClip idleClip = new AnimationClip("Idle", Animations.Get("Idle"));
            idleClip.Add(Animations.Get("Blink"), 3000);
            idleClip.Add(Animations.Get("Blink"), 6000);
            idleClip.Add(Animations.Get("Blink"), 9000);

            AnimationClip sleepClip = new AnimationClip("Sleep", Animations.Get("Sleep"));
            sleepClip.Add(Animations.Get(new string[] { "LookAround", "Laydown" }), 0);
            sleepClip.Add(Animations.Get(new string[] { "Standup", "Blink", "LookAround" }), 30000);

            AnimationClip awakenClip = new AnimationClip("Awaken", Animations.Get("Sleep"));
            awakenClip.Add(Animations.Get(new string[] { "Standup", "LookAround" }), 1000);

            Clips.Add(idleClip);
            Clips.Add(sleepClip);
            Clips.Add(awakenClip);

            Sounds.Add("Meow", $"{_soundsPath}\\meow.wav");
            Sounds.Add("Purring", $"{_soundsPath}\\purring.wav");
            Sounds.Add("Hisses", $"{_soundsPath}\\hisses.wav");
            
            _isInitialized = true;
        }

        private void Load(string animationDirectory)
        {
            var directories = Directory.GetDirectories(animationDirectory);

            foreach (var directory in directories)
            {
                string animationName = directory.Substring(directory.LastIndexOf('/') + 1);
                string[] animationFrames = Directory.GetFiles(animationName);

                if (animationFrames.Length == 0)
                {
                    string[] subAnimationNames = Directory.GetDirectories(animationName);

                    foreach (var subAnimationName in subAnimationNames)
                    {
                        animationFrames = Directory.GetFiles(subAnimationName);

                        if (animationFrames.Length == 0)
                        {
                            throw new Exception("Unsupported animation nesting.", new FileNotFoundException($"No files in {animationFrames}."));
                        }

                        Image[] frames = new Image[animationFrames.Length];

                        for (int i = 0; i < frames.Length; i++)
                        {
                            frames[i] = new Bitmap(animationFrames[i]);
                        }

                        animationName = $"{animationName.Substring(animationName.LastIndexOf("\\") + 1)}-{subAnimationName.Substring(subAnimationName.LastIndexOf("\\") + 1)}";

                        // Add animation frames
                    }
                }
                else
                {
                    Image[] frames = new Image[animationFrames.Length];

                    for (int i = 0; i < frames.Length; i++)
                    {
                        frames[i] = new Bitmap(animationFrames[i]);
                    }

                    animationName = animationName.Substring(animationName.LastIndexOf("\\") + 1);

                    // Add animation frames
                }
            }
        }
    }
}
