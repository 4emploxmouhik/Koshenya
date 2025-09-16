using Koshenya.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Koshenya.Forms.Controls
{
    public partial class AnimationsListViewUC : UserControl, IAnimationBox
    {
        private readonly AnimationPlayer _player;
        private bool _isAnimationPlayed;

        public AnimationsListViewUC()
        {
            _player = new AnimationPlayer(this);

            InitializeComponent();
        }

        public List<CharacterConfiguration.Animation> Animations { get; } = new List<CharacterConfiguration.Animation>();
        public Image Frame
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text)
                || string.IsNullOrEmpty(sourceTextBox.Text))
            {
                MessageBox.Show("Set the name and source of animation.", "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(sourceTextBox.Text))
            {
                MessageBox.Show("Couldn't find an animation folder.", "Bad path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Animations.Any(x => x.Name == nameTextBox.Text))
            {
                MessageBox.Show("Animation with that name alredy added.", "Bad animation name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animations.Add(new CharacterConfiguration.Animation()
            {
                Name = nameTextBox.Text,
                Source = sourceTextBox.Text,
                FrameRate = Convert.ToInt32(fpsNumericUpDown.Value),
                IsReverse = reverseCheckBox.Checked,
                IsReflected = reflectedCheckBox.Checked
            });
            listBox.Items.Add(nameTextBox.Text);
        }

        private void AddAllButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo animationsDirectory = new DirectoryInfo(dialog.SelectedPath);
                    int lvl = 0;

                    foreach (var directory in animationsDirectory.GetDirectories())
                        FillAnimationsList(directory, ref lvl);
                }
            }
        }

        private void FillAnimationsList(DirectoryInfo directory, ref int lvl)
        {
            DirectoryInfo[] childs = directory.GetDirectories();

            if (childs.Length == 0)
            {
                string name = lvl == 0 ? directory.Name : $"{directory.Parent}-{directory.Name}";
                string source = directory.FullName;

                Animations.Add(new CharacterConfiguration.Animation()
                {
                    Name = name,
                    Source = source,
                    FrameRate = 24,
                    IsReverse = false,
                    IsReflected = false
                });
                listBox.Items.Add(name);

                if (lvl > 0)
                    lvl--;
            }
            else
            {
                foreach (var child in childs)
                {
                    lvl++;
                    FillAnimationsList(child, ref lvl);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                string msg = listBox.Items.Count == 0 ? "Animations list is empty." : "First, select an animation from the list.";

                MessageBox.Show(msg, "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(sourceTextBox.Text))
            {
                MessageBox.Show("Couldn't find an animation folder.", "Bad path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var selectedAnimation = Animations.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());
            selectedAnimation.Name = nameTextBox.Text;
            selectedAnimation.Source = sourceTextBox.Text;
            selectedAnimation.FrameRate = Convert.ToInt32(fpsNumericUpDown.Value);
            selectedAnimation.IsReverse = reverseCheckBox.Checked;
            selectedAnimation.IsReflected = reflectedCheckBox.Checked;

            listBox.Items[listBox.SelectedIndex] = selectedAnimation.Name;

            if (_isAnimationPlayed)
            {
                _player.Play(new Animation(
                    selectedAnimation.Name,
                    Animation.Load(selectedAnimation.Source, selectedAnimation.IsReflected, selectedAnimation.IsReverse),
                    selectedAnimation.FrameRate
                ));
            }

            MessageBox.Show("Animation changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                string msg = listBox.Items.Count == 0 ? "Animations list is empty." : "First, select an animation from the list.";

                MessageBox.Show(msg, "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isAnimationPlayed)
            {
                _player.Stop();
                _isAnimationPlayed = false;
                playButton.Text = "Play";

            }
            else
            {
                var selectedAnimation = Animations.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());

                _player.Play(new Animation(
                    selectedAnimation.Name,
                    Animation.Load(selectedAnimation.Source, selectedAnimation.IsReflected, selectedAnimation.IsReverse),
                    selectedAnimation.FrameRate
                ));
                _player.Start();
                _isAnimationPlayed = true;
                playButton.Text = "Stop";
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                string msg = listBox.Items.Count == 0 ? "Animations list is empty." : "First, select an animation from the list.";

                MessageBox.Show(msg, "Something missed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedAnimation = Animations.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());
            Animations.Remove(selectedAnimation);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            Animations.Clear();
            listBox.Items.Clear();
            nameTextBox.Clear();
            sourceTextBox.Clear();
            fpsNumericUpDown.Value = 24;
            reverseCheckBox.Checked = false;
            reflectedCheckBox.Checked = false;
            _player.Stop();
            _isAnimationPlayed = false;
            playButton.Text = "Play";
            Frame = null;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    sourceTextBox.Text = dialog.SelectedPath;
                    nameTextBox.Text = sourceTextBox.Text.Substring(sourceTextBox.Text.LastIndexOf('\\') + 1);
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                var selectedAnimation = Animations.First(x => x.Name == listBox.Items[listBox.SelectedIndex].ToString());

                nameTextBox.Text = selectedAnimation.Name;
                sourceTextBox.Text = selectedAnimation.Source;
                fpsNumericUpDown.Value = Convert.ToInt32(selectedAnimation.FrameRate);
                reverseCheckBox.Checked = selectedAnimation.IsReverse;
                reflectedCheckBox.Checked = selectedAnimation.IsReflected;

                if (_isAnimationPlayed)
                {
                    _player.Play(new Animation(
                        selectedAnimation.Name,
                        Animation.Load(selectedAnimation.Source, selectedAnimation.IsReflected, selectedAnimation.IsReverse),
                        selectedAnimation.FrameRate
                    ));
                }
            }
        }
    }
}
