namespace Koshenya.Forms
{
    partial class CharacterConfigurationForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.Button saveButton;
            System.Windows.Forms.Button cancelButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterConfigurationForm));
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionalStatesGroupBox = new System.Windows.Forms.GroupBox();
            this.punchStateCheckBox = new System.Windows.Forms.CheckBox();
            this.dragStateCheckBox = new System.Windows.Forms.CheckBox();
            this.sleepStateCheckBox = new System.Windows.Forms.CheckBox();
            this.baseStatesGroupBox = new System.Windows.Forms.GroupBox();
            this.moveStateCheckBox = new System.Windows.Forms.CheckBox();
            this.idleStateCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.animationsListViewUC = new Koshenya.Forms.Controls.AnimationsListViewUC();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.soundsListViewUC = new Koshenya.Forms.Controls.SoundsListViewUC();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.manageStatesButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            saveButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            this.optionalStatesGroupBox.SuspendLayout();
            this.baseStatesGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(103, 15);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.characterNameTextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 13);
            label3.TabIndex = 27;
            label3.Text = "Character name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Select states for your character";
            // 
            // optionalStatesGroupBox
            // 
            this.optionalStatesGroupBox.Controls.Add(this.punchStateCheckBox);
            this.optionalStatesGroupBox.Controls.Add(this.dragStateCheckBox);
            this.optionalStatesGroupBox.Controls.Add(this.sleepStateCheckBox);
            this.optionalStatesGroupBox.Location = new System.Drawing.Point(113, 37);
            this.optionalStatesGroupBox.Name = "optionalStatesGroupBox";
            this.optionalStatesGroupBox.Size = new System.Drawing.Size(101, 93);
            this.optionalStatesGroupBox.TabIndex = 34;
            this.optionalStatesGroupBox.TabStop = false;
            this.optionalStatesGroupBox.Text = "Optional states";
            // 
            // punchStateCheckBox
            // 
            this.punchStateCheckBox.AutoSize = true;
            this.punchStateCheckBox.Location = new System.Drawing.Point(12, 24);
            this.punchStateCheckBox.Name = "punchStateCheckBox";
            this.punchStateCheckBox.Size = new System.Drawing.Size(57, 17);
            this.punchStateCheckBox.TabIndex = 7;
            this.punchStateCheckBox.Tag = "Punch";
            this.punchStateCheckBox.Text = "Punch";
            this.punchStateCheckBox.UseVisualStyleBackColor = true;
            this.punchStateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // dragStateCheckBox
            // 
            this.dragStateCheckBox.AutoSize = true;
            this.dragStateCheckBox.Location = new System.Drawing.Point(12, 68);
            this.dragStateCheckBox.Name = "dragStateCheckBox";
            this.dragStateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dragStateCheckBox.TabIndex = 6;
            this.dragStateCheckBox.Tag = "Drag";
            this.dragStateCheckBox.Text = "Drag";
            this.dragStateCheckBox.UseVisualStyleBackColor = true;
            this.dragStateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // sleepStateCheckBox
            // 
            this.sleepStateCheckBox.AutoSize = true;
            this.sleepStateCheckBox.Location = new System.Drawing.Point(12, 47);
            this.sleepStateCheckBox.Name = "sleepStateCheckBox";
            this.sleepStateCheckBox.Size = new System.Drawing.Size(53, 17);
            this.sleepStateCheckBox.TabIndex = 4;
            this.sleepStateCheckBox.Tag = "Sleep";
            this.sleepStateCheckBox.Text = "Sleep";
            this.sleepStateCheckBox.UseVisualStyleBackColor = true;
            this.sleepStateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // baseStatesGroupBox
            // 
            this.baseStatesGroupBox.Controls.Add(this.moveStateCheckBox);
            this.baseStatesGroupBox.Controls.Add(this.idleStateCheckBox);
            this.baseStatesGroupBox.Location = new System.Drawing.Point(6, 37);
            this.baseStatesGroupBox.Name = "baseStatesGroupBox";
            this.baseStatesGroupBox.Size = new System.Drawing.Size(101, 73);
            this.baseStatesGroupBox.TabIndex = 33;
            this.baseStatesGroupBox.TabStop = false;
            this.baseStatesGroupBox.Text = "Base states";
            // 
            // moveStateCheckBox
            // 
            this.moveStateCheckBox.AutoSize = true;
            this.moveStateCheckBox.Checked = true;
            this.moveStateCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.moveStateCheckBox.Location = new System.Drawing.Point(12, 47);
            this.moveStateCheckBox.Name = "moveStateCheckBox";
            this.moveStateCheckBox.Size = new System.Drawing.Size(53, 17);
            this.moveStateCheckBox.TabIndex = 6;
            this.moveStateCheckBox.Tag = "Move";
            this.moveStateCheckBox.Text = "Move";
            this.moveStateCheckBox.UseVisualStyleBackColor = true;
            this.moveStateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // idleStateCheckBox
            // 
            this.idleStateCheckBox.AutoSize = true;
            this.idleStateCheckBox.Checked = true;
            this.idleStateCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.idleStateCheckBox.Location = new System.Drawing.Point(12, 24);
            this.idleStateCheckBox.Name = "idleStateCheckBox";
            this.idleStateCheckBox.Size = new System.Drawing.Size(43, 17);
            this.idleStateCheckBox.TabIndex = 4;
            this.idleStateCheckBox.Tag = "Idle";
            this.idleStateCheckBox.Text = "Idle";
            this.idleStateCheckBox.UseVisualStyleBackColor = true;
            this.idleStateCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Location = new System.Drawing.Point(12, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(390, 300);
            tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.animationsListViewUC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Animations";
            // 
            // animationsListViewUC
            // 
            this.animationsListViewUC.Frame = null;
            this.animationsListViewUC.Location = new System.Drawing.Point(3, 3);
            this.animationsListViewUC.Name = "animationsListViewUC";
            this.animationsListViewUC.Size = new System.Drawing.Size(374, 265);
            this.animationsListViewUC.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.soundsListViewUC);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sounds";
            // 
            // soundsListViewUC
            // 
            this.soundsListViewUC.Location = new System.Drawing.Point(3, 3);
            this.soundsListViewUC.Name = "soundsListViewUC";
            this.soundsListViewUC.Size = new System.Drawing.Size(376, 238);
            this.soundsListViewUC.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.manageStatesButton);
            this.tabPage3.Controls.Add(this.baseStatesGroupBox);
            this.tabPage3.Controls.Add(this.optionalStatesGroupBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "States";
            // 
            // manageStatesButton
            // 
            this.manageStatesButton.Location = new System.Drawing.Point(113, 245);
            this.manageStatesButton.Name = "manageStatesButton";
            this.manageStatesButton.Size = new System.Drawing.Size(155, 23);
            this.manageStatesButton.TabIndex = 39;
            this.manageStatesButton.Text = "Manage states parametrs";
            this.manageStatesButton.UseVisualStyleBackColor = true;
            this.manageStatesButton.Click += new System.EventHandler(this.ManageStatesButton_Click);
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(129, 368);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(75, 23);
            saveButton.TabIndex = 37;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(210, 368);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 38;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CharacterConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 402);
            this.Controls.Add(cancelButton);
            this.Controls.Add(saveButton);
            this.Controls.Add(tabControl1);
            this.Controls.Add(label3);
            this.Controls.Add(this.characterNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterConfigurationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koshenya: New Character";
            this.optionalStatesGroupBox.ResumeLayout(false);
            this.optionalStatesGroupBox.PerformLayout();
            this.baseStatesGroupBox.ResumeLayout(false);
            this.baseStatesGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox optionalStatesGroupBox;
        private System.Windows.Forms.CheckBox punchStateCheckBox;
        private System.Windows.Forms.CheckBox dragStateCheckBox;
        private System.Windows.Forms.CheckBox sleepStateCheckBox;
        private System.Windows.Forms.GroupBox baseStatesGroupBox;
        private System.Windows.Forms.CheckBox moveStateCheckBox;
        private System.Windows.Forms.CheckBox idleStateCheckBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button manageStatesButton;
        private Controls.AnimationsListViewUC animationsListViewUC;
        private Controls.SoundsListViewUC soundsListViewUC;
    }
}