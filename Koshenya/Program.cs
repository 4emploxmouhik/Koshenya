using Koshenya.Forms;
using Koshenya.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Koshenya
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Run(args);
            }
            catch (Exception ex)
            {
                ExceptionInfoForm.Show(ex);
            }
        }

        public static void Restart(string characterName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                Arguments = characterName
            };

            Process.Start(startInfo);
            Application.Exit();
        }

        private static void Run(string[] args)
        {
            var assetsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Assets");
            var characters = GetCharactersList(assetsDirectory);

            if (args.Length == 1)
            {
                var characterName = args[0];

                if (!characters.Contains(characterName))
                {
                    MessageBox.Show(
                        $"Character [{characterName}] configuration file not founded. " +
                        $"Check, if you have a folder named like your character with configuration file (\".conf\") " +
                        $"at assets folder [{assetsDirectory}].",
                        "Error! Not Found.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Application.Run(new CharacterBox(characterName, characters));
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.CurrentCharacterName)
                    && characters.Contains(Settings.Default.CurrentCharacterName))
                {
                    Application.Run(new CharacterBox(Settings.Default.CurrentCharacterName, characters));
                }
                else
                {
                    Application.Run(new CharacterBox(characters));
                }
            }
        }

        private static List<string> GetCharactersList(string assetsDirectory)
        {
            var characters = new List<string>() { "Koshenya" };

            if (Directory.Exists(assetsDirectory))
            {
                var directories = Directory.GetDirectories(assetsDirectory);

                foreach (var directory in directories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);

                    if (directoryInfo.GetFiles().Select(x => x.Name).Contains(".conf"))
                    {
                        characters.Add(directoryInfo.Name);
                    }
                }
            }

            return characters;
        }
    }
}
