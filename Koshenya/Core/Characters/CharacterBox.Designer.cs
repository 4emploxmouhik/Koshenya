using Koshenya.Properties;

namespace Koshenya.Core
{
    partial class CharacterBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterBox));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.choseCharacterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyCatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownCatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCharacterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAssetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Koshenya";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choseCharacterMenuItem,
            this.createCharacterMenuItem,
            this.manageAssetsMenuItem,
            this.muteMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 136);
            // 
            // choseCharacterMenuItem
            // 
            this.choseCharacterMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyCatMenuItem,
            this.brownCatMenuItem});
            this.choseCharacterMenuItem.Name = "choseCharacterMenuItem";
            this.choseCharacterMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choseCharacterMenuItem.Text = "Character";
            // 
            // greyCatMenuItem
            // 
            this.greyCatMenuItem.Checked = true;
            this.greyCatMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greyCatMenuItem.Name = "greyCatMenuItem";
            this.greyCatMenuItem.Size = new System.Drawing.Size(129, 22);
            this.greyCatMenuItem.Tag = "Grey";
            this.greyCatMenuItem.Text = "Grey Cat";
            this.greyCatMenuItem.Click += new System.EventHandler(this.CatMenuItem_Click);
            // 
            // brownCatMenuItem
            // 
            this.brownCatMenuItem.Name = "brownCatMenuItem";
            this.brownCatMenuItem.Size = new System.Drawing.Size(129, 22);
            this.brownCatMenuItem.Tag = "Brown";
            this.brownCatMenuItem.Text = "Brown Cat";
            this.brownCatMenuItem.Click += new System.EventHandler(this.CatMenuItem_Click);
            // 
            // createCharacterMenuItem
            // 
            this.createCharacterMenuItem.Enabled = false;
            this.createCharacterMenuItem.Name = "createCharacterMenuItem";
            this.createCharacterMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createCharacterMenuItem.Text = "Create new";
            this.createCharacterMenuItem.Click += new System.EventHandler(this.CreateCharacterMenuItem_Click);
            // 
            // manageAssetsMenuItem
            // 
            this.manageAssetsMenuItem.Name = "manageAssetsMenuItem";
            this.manageAssetsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageAssetsMenuItem.Text = "Manage assets";
            this.manageAssetsMenuItem.Click += new System.EventHandler(this.ManageAssetsMenuItem_Click);
            // 
            // muteMenuItem
            // 
            this.muteMenuItem.Name = "muteMenuItem";
            this.muteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.muteMenuItem.Text = "Mute";
            this.muteMenuItem.Checked = Settings.Default.IsMutted;
            this.muteMenuItem.Click += new System.EventHandler(this.MuteMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // CharacterBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(64, 64);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(64, 64);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(64, 64);
            this.Name = "CharacterBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koshenya";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createCharacterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choseCharacterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAssetsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownCatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyCatMenuItem;
    }
}