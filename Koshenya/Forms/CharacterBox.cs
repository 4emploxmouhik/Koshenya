using Koshenya.Core;
using Koshenya.Core.Extensions;
using Koshenya.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Koshenya.Forms
{
    internal partial class CharacterBox : Form, ICharacterBox
    {
        private readonly Character _character;

        public CharacterBox(List<string> availableCharacters)
        {
            InitializeComponent();
            InitializeCharactersMenuList(availableCharacters);

            _character = new Character(this);

            InitializeDefaultCharacter();
            Run();
        }

        public CharacterBox(string characterName, List<string> availableCharacters)
        {
            InitializeComponent();
            InitializeCharactersMenuList(availableCharacters);

            _character = new Character(this);

            if (characterName == "Koshenya")
            {
                InitializeDefaultCharacter();
            }
            else
            {
                var characterFolder = $@"{Directory.GetCurrentDirectory()}\Assets\{characterName}";
                var config = CharacterConfiguration.Read($@"{characterFolder}\.conf");

                _character.Name = characterName;
                _character.DeclareStates(config);
            }

            Run();
        }

        private void InitializeCharactersMenuList(List<string> availableCharacters)
        {
            foreach (var character in availableCharacters)
            {
                var charcterMenuItem = new ToolStripMenuItem() { Name = character, Text = character };
                charcterMenuItem.Click += OnCharacterChanged;

                choseCharacterMenuItem.DropDownItems.Add(charcterMenuItem);
            }
        }

        public Image Frame
        {
            get => BackgroundImage;
            set => BackgroundImage = value;
        }
        public new Point Location
        {
            get => new Point(Left + Size.Width / 2, Top + Size.Height / 2);
            set
            {
                Left = value.X - Size.Width / 2;
                Top = value.Y - Size.Height / 2;
            }
        }

        private void Run()
        {
            _character.SetState(CharacterStateType.Idle);
            _character.Start();

            Settings.Default.CurrentCharacterName = _character.Name;
            Settings.Default.Save();

            ((ToolStripMenuItem)choseCharacterMenuItem.DropDownItems[_character.Name]).Checked = true;
        }

        private void OnCharacterChanged(object sender, EventArgs e)
        {
            Program.Restart(((ToolStripMenuItem)sender).Text);
        }

        private void CharacterBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _character.Punch();
        }

        private void CharacterBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _character.DraggingStart();
        }

        private void CharacterBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_character.IsDraggingModeActive)
            {
                User32Dll.GetCursorPos(out Point point);
                Location = point;
            }
        }

        private void CharacterBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _character.DraggingEnd();
        }

        #region Menu
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MuteMenuItem_Click(object sender, EventArgs e)
        {
            _character.Mute();
            muteMenuItem.Checked = Settings.Default.IsMutted;
        }

        private void CreateCharacterMenuItem_Click(object sender, EventArgs e)
        {
            _character.Stop();

            using (CharacterConfigurationForm form = new CharacterConfigurationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("New character configuration saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (form.DialogResult == DialogResult.Abort)
                    MessageBox.Show("Saving new character configuration interrupted.", "Something goes wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _character.Start();
        }

        private void ManageAssetsMenuItem_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string assetsDirectory = Path.Combine(currentDirectory, "Assets");

            Process.Start("explorer.exe", Directory.Exists(assetsDirectory) ? assetsDirectory : currentDirectory);
        }

        private void PatrolMenuItem_Click(object sender, EventArgs e)
        {
            patrolToolStripMenuItem.Checked = !patrolToolStripMenuItem.Checked;
            _character.Patrol();
        }
        #endregion
    }
}