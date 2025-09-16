using Koshenya.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls
{
    public partial class SoundsListViewUC : UserControl
    {
        private readonly SoundPlayer _player = new SoundPlayer();
        private bool _isSoundPlaying;

        public SoundsListViewUC()
        {
            InitializeComponent();
        }

        public List<CharacterConfiguration.Sound> Sounds { get; } = new List<CharacterConfiguration.Sound>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text)
               || string.IsNullOrEmpty(sourceTextBox.Text))
            {
                MessageBox.Show("Set the name and source of sound.", "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!sourceTextBox.Text.EndsWith(".wav"))
            {
                MessageBox.Show("File not supported. Support only .wav files.", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(sourceTextBox.Text))
            {
                MessageBox.Show("File not found.", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sounds.Add(new CharacterConfiguration.Sound()
            {
                Name = nameTextBox.Text,
                Source = sourceTextBox.Text,
            });
            listBox.Items.Add(nameTextBox.Text);
        }

        private void AddAllbutton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                    FileInfo[] files = directory.GetFiles();

                    foreach (var file in files)
                    {
                        if (file.Extension != ".wav")
                            continue;

                        string name = file.Name.Substring(0, file.Name.LastIndexOf('.'));

                        Sounds.Add(new CharacterConfiguration.Sound()
                        {
                            Name = name,
                            Source = file.FullName,
                        });
                        listBox.Items.Add(name);
                    }
                }
            }
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                string msg = listBox.Items.Count == 0 ? "Sounds list is empty." : "First, select a sound from the list.";

                MessageBox.Show(msg, "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isSoundPlaying)
            {
                _player.Stop();
                _isSoundPlaying = false;
                playButton.Text = "Play";
            }
            else
            {
                var selectedSound = Sounds.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());

                _player.SoundLocation = selectedSound.Source;
                _player.Load();
                _player.Play();
                _isSoundPlaying = true;
                playButton.Text = "Stop";
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                string msg = listBox.Items.Count == 0 ? "Sounds list is empty." : "First, select a sound from the list.";

                MessageBox.Show(msg, "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedSound = Sounds.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());
            Sounds.Remove(selectedSound);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "Sound files (*.wav)|*.wav" } )
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sourceTextBox.Text = dialog.FileName;

                    string name = dialog.FileName.Substring(dialog.FileName.LastIndexOf('\\') + 1);
                    name = name.Substring(0, name.LastIndexOf('.'));

                    nameTextBox.Text = name;
                }
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            Sounds.Clear();
            listBox.Items.Clear();
            nameTextBox.Clear();
            sourceTextBox.Clear();
            _player.Stop();
            _isSoundPlaying = false;
            playButton.Text = "Play";
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                var selectedSound = Sounds.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());

                nameTextBox.Text = selectedSound.Name;
                sourceTextBox.Text = selectedSound.Source;

                if (_isSoundPlaying)
                {
                    _player.SoundLocation = selectedSound.Source;
                    _player.Load();
                    _player.PlayLooping();
                }
            }
        }
    }
}
