namespace Koshenya.Forms
{
    partial class CharacterStatesConfigurationForm
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
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.Button cancelButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterStatesConfigurationForm));
            this.statesTabControl = new System.Windows.Forms.TabControl();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statesTabControl
            // 
            this.statesTabControl.Location = new System.Drawing.Point(12, 12);
            this.statesTabControl.Name = "statesTabControl";
            this.statesTabControl.SelectedIndex = 0;
            this.statesTabControl.Size = new System.Drawing.Size(440, 390);
            this.statesTabControl.TabIndex = 11;
            // 
            // okButton
            // 
            okButton.Location = new System.Drawing.Point(154, 408);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 12;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(235, 408);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CharacterStatesConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 438);
            this.Controls.Add(cancelButton);
            this.Controls.Add(okButton);
            this.Controls.Add(this.statesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterStatesConfigurationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koshenya: States Configuration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statesTabControl;
    }
}