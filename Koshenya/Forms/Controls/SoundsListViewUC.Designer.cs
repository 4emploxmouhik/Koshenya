namespace Koshenya.Forms.Controls
{
    partial class SoundsListViewUC
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
            System.Windows.Forms.Button removeButton;
            System.Windows.Forms.Button addButton;
            System.Windows.Forms.Button browseButton;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.playButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            removeButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            browseButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(157, 117);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(63, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // removeButton
            // 
            removeButton.Location = new System.Drawing.Point(226, 117);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(63, 23);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(88, 117);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(63, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += new System.EventHandler(this.AddButton_Click);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(0, 200);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 13);
            label6.TabIndex = 48;
            label6.Text = "Source:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(0, 161);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 13);
            label7.TabIndex = 46;
            label7.Text = "Name:";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(3, 216);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(200, 20);
            this.sourceTextBox.TabIndex = 3;
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 177);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // SoundsListViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playButton);
            this.Controls.Add(removeButton);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(browseButton);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Name = "SoundsListViewUC";
            this.Size = new System.Drawing.Size(373, 246);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button playButton;
    }
}
