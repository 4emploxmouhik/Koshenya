using Koshenya.Core.Characters.Cat;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal partial class CharacterBox : Form, ICharacterBox
    {
        protected Character character;

        public CharacterBox()
        {
            InitializeComponent();
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

        public void SetCharacter(Character character)
        {
            this.character = character;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MuteMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Checked = !menuItem.Checked;

            character.Mute(menuItem.Checked);
        }

        private void CreateCharacterMenuItem_Click(object sender, EventArgs e)
        {
            character.Stop();

            // TODO: actions for saving new character

            character.Start();
        }

        private void ManageAssetsMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"{Directory.GetCurrentDirectory()}\\Assets\\Cat");
        }

        private void CatMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            character.Stop();

            if ((string)menuItem.Tag == "Brown")
            {
                if (((CatAssets)character.Assets).CatColor != "Brown")
                {
                    character.Assets = new CatAssets("Brown");
                }
            }
            else if ((string)menuItem.Tag == "Grey")
            {
                if (((CatAssets)character.Assets).CatColor != "Grey")
                {
                    character.Assets = new CatAssets("Grey");
                }
            }

            foreach (ToolStripMenuItem item in menuItem.Owner.Items)
            {
                item.Checked = false;
            }
            menuItem.Checked = true;

            character.Start();
        }
    }
}
