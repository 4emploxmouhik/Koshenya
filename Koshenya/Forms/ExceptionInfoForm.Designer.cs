namespace Koshenya.Forms
{
    partial class ExceptionInfoForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Button okButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionInfoForm));
            this.stackTraceTextBox = new System.Windows.Forms.TextBox();
            this.exceptionTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 130);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 13);
            label1.TabIndex = 1;
            label1.Text = "Stack Trace:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 2;
            label2.Text = "Exception:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 13);
            label3.TabIndex = 4;
            label3.Text = "Message:";
            // 
            // stackTraceTextBox
            // 
            this.stackTraceTextBox.BackColor = System.Drawing.Color.White;
            this.stackTraceTextBox.Location = new System.Drawing.Point(15, 146);
            this.stackTraceTextBox.Multiline = true;
            this.stackTraceTextBox.Name = "stackTraceTextBox";
            this.stackTraceTextBox.ReadOnly = true;
            this.stackTraceTextBox.Size = new System.Drawing.Size(358, 209);
            this.stackTraceTextBox.TabIndex = 0;
            // 
            // exceptionTextBox
            // 
            this.exceptionTextBox.BackColor = System.Drawing.Color.White;
            this.exceptionTextBox.Location = new System.Drawing.Point(75, 17);
            this.exceptionTextBox.Name = "exceptionTextBox";
            this.exceptionTextBox.ReadOnly = true;
            this.exceptionTextBox.Size = new System.Drawing.Size(298, 20);
            this.exceptionTextBox.TabIndex = 3;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.Location = new System.Drawing.Point(71, 51);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(302, 57);
            this.messageTextBox.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new System.Drawing.Point(157, 361);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExceptionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 392);
            this.Controls.Add(okButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.exceptionTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.stackTraceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionInfoForm";
            this.Text = "Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stackTraceTextBox;
        private System.Windows.Forms.TextBox exceptionTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}