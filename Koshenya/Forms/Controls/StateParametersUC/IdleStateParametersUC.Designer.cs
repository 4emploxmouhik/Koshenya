using System.Collections.Generic;

namespace Koshenya.Forms.Controls.StateParametersUC
{
    partial class IdleStateParametersUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.animsListBox = new System.Windows.Forms.ListBox();
            this.animsComboBox = new System.Windows.Forms.ComboBox();
            this.defaultAnimComboBox = new System.Windows.Forms.ComboBox();
            this.timeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeBeforeSleepNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBeforeSleepNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 22;
            label2.Text = "Default animation:";
            // 
            // animsListBox
            // 
            this.animsListBox.FormattingEnabled = true;
            this.animsListBox.Location = new System.Drawing.Point(15, 53);
            this.animsListBox.Name = "animsListBox";
            this.animsListBox.Size = new System.Drawing.Size(279, 56);
            this.animsListBox.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(300, 82);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(41, 23);
            button2.TabIndex = 20;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.RemoveAnimButton_Click);
            // 
            // animsComboBox
            // 
            this.animsComboBox.FormattingEnabled = true;
            this.animsComboBox.Location = new System.Drawing.Point(80, 115);
            this.animsComboBox.Name = "animsComboBox";
            this.animsComboBox.Size = new System.Drawing.Size(105, 21);
            this.animsComboBox.TabIndex = 16;
            // 
            // defaultAnimComboBox
            // 
            this.defaultAnimComboBox.FormattingEnabled = true;
            this.defaultAnimComboBox.Location = new System.Drawing.Point(110, 10);
            this.defaultAnimComboBox.Name = "defaultAnimComboBox";
            this.defaultAnimComboBox.Size = new System.Drawing.Size(105, 21);
            this.defaultAnimComboBox.TabIndex = 21;
            this.defaultAnimComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultAnimComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(300, 53);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(41, 23);
            button1.TabIndex = 17;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.AddAnimButton_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 18;
            label3.Text = "Animation:";
            // 
            // timeNumUpDown
            // 
            this.timeNumUpDown.Location = new System.Drawing.Point(230, 116);
            this.timeNumUpDown.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.timeNumUpDown.Name = "timeNumUpDown";
            this.timeNumUpDown.Size = new System.Drawing.Size(64, 20);
            this.timeNumUpDown.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(191, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 25;
            label4.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 149);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 13);
            label5.TabIndex = 27;
            label5.Text = "Time before sleep:";
            // 
            // timeBeforeSleepNumUpDown
            // 
            this.timeBeforeSleepNumUpDown.Location = new System.Drawing.Point(118, 147);
            this.timeBeforeSleepNumUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeBeforeSleepNumUpDown.Name = "timeBeforeSleepNumUpDown";
            this.timeBeforeSleepNumUpDown.Size = new System.Drawing.Size(43, 20);
            this.timeBeforeSleepNumUpDown.TabIndex = 26;
            this.timeBeforeSleepNumUpDown.ValueChanged += new System.EventHandler(this.TimeBeforeSleepNumUpDown_ValueChanged);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(167, 151);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 13);
            label6.TabIndex = 28;
            label6.Text = "min";
            // 
            // timeUnitComboBox
            // 
            this.timeUnitComboBox.FormattingEnabled = true;
            this.timeUnitComboBox.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.timeUnitComboBox.Location = new System.Drawing.Point(300, 116);
            this.timeUnitComboBox.Name = "timeUnitComboBox";
            this.timeUnitComboBox.Size = new System.Drawing.Size(41, 21);
            this.timeUnitComboBox.TabIndex = 29;
            // 
            // IdleStateParametersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeUnitComboBox);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.timeBeforeSleepNumUpDown);
            this.Controls.Add(label4);
            this.Controls.Add(this.timeNumUpDown);
            this.Controls.Add(label2);
            this.Controls.Add(this.animsListBox);
            this.Controls.Add(button2);
            this.Controls.Add(this.animsComboBox);
            this.Controls.Add(this.defaultAnimComboBox);
            this.Controls.Add(button1);
            this.Controls.Add(label3);
            this.Name = "IdleStateParametersUC";
            this.Size = new System.Drawing.Size(353, 176);
            ((System.ComponentModel.ISupportInitialize)(this.timeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBeforeSleepNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox animsListBox;
        private System.Windows.Forms.ComboBox animsComboBox;
        private System.Windows.Forms.ComboBox defaultAnimComboBox;
        private System.Windows.Forms.NumericUpDown timeNumUpDown;
        private System.Windows.Forms.NumericUpDown timeBeforeSleepNumUpDown;
        private System.Windows.Forms.ComboBox timeUnitComboBox;
    }
}
