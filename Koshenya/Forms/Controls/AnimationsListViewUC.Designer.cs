namespace Koshenya.Forms.Controls
{
    partial class AnimationsListViewUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button editButton;
            System.Windows.Forms.Button addButton;
            System.Windows.Forms.Button removeButton;
            System.Windows.Forms.Button browseButton;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button addAllButton;
            System.Windows.Forms.Button clearAllButton;
            this.playButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fpsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.listBox = new System.Windows.Forms.ListBox();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.reverseCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reflectedCheckBox = new System.Windows.Forms.CheckBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            editButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            removeButton = new System.Windows.Forms.Button();
            browseButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            addAllButton = new System.Windows.Forms.Button();
            clearAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new System.Drawing.Point(128, 117);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(55, 23);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(6, 117);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(55, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            removeButton.Location = new System.Drawing.Point(250, 117);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(55, 23);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // browseButton
            // 
            browseButton.Location = new System.Drawing.Point(209, 214);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(57, 23);
            browseButton.TabIndex = 4;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 161);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 39;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 13);
            label2.TabIndex = 42;
            label2.Text = "Source:";
            // 
            // addAllButton
            // 
            addAllButton.Location = new System.Drawing.Point(67, 117);
            addAllButton.Name = "addAllButton";
            addAllButton.Size = new System.Drawing.Size(55, 23);
            addAllButton.TabIndex = 48;
            addAllButton.Text = "Add All";
            addAllButton.UseVisualStyleBackColor = true;
            addAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
            // 
            // clearAllButton
            // 
            clearAllButton.Location = new System.Drawing.Point(311, 117);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new System.Drawing.Size(55, 23);
            clearAllButton.TabIndex = 49;
            clearAllButton.Text = "Clear All";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(189, 117);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(55, 23);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(272, 161);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(98, 95);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 47;
            this.pictureBox.TabStop = false;
            // 
            // fpsNumericUpDown
            // 
            this.fpsNumericUpDown.Location = new System.Drawing.Point(36, 242);
            this.fpsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fpsNumericUpDown.Name = "fpsNumericUpDown";
            this.fpsNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.fpsNumericUpDown.TabIndex = 5;
            this.fpsNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(3, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(367, 108);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(3, 216);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(200, 20);
            this.sourceTextBox.TabIndex = 3;
            // 
            // reverseCheckBox
            // 
            this.reverseCheckBox.AutoSize = true;
            this.reverseCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reverseCheckBox.Location = new System.Drawing.Point(92, 244);
            this.reverseCheckBox.Name = "reverseCheckBox";
            this.reverseCheckBox.Size = new System.Drawing.Size(66, 17);
            this.reverseCheckBox.TabIndex = 6;
            this.reverseCheckBox.Text = "Reverse";
            this.reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 177);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // reflectedCheckBox
            // 
            this.reflectedCheckBox.AutoSize = true;
            this.reflectedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reflectedCheckBox.Location = new System.Drawing.Point(164, 244);
            this.reflectedCheckBox.Name = "reflectedCheckBox";
            this.reflectedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.reflectedCheckBox.TabIndex = 7;
            this.reflectedCheckBox.Text = "Reflected";
            this.reflectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(0, 246);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(30, 13);
            this.fpsLabel.TabIndex = 46;
            this.fpsLabel.Text = "FPS:";
            // 
            // AnimationsListViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(clearAllButton);
            this.Controls.Add(addAllButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(editButton);
            this.Controls.Add(this.fpsNumericUpDown);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(addButton);
            this.Controls.Add(this.reverseCheckBox);
            this.Controls.Add(removeButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.reflectedCheckBox);
            this.Controls.Add(browseButton);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.fpsLabel);
            this.Name = "AnimationsListViewUC";
            this.Size = new System.Drawing.Size(374, 265);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown fpsNumericUpDown;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.CheckBox reverseCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox reflectedCheckBox;
        private System.Windows.Forms.Label fpsLabel;
    }
}
