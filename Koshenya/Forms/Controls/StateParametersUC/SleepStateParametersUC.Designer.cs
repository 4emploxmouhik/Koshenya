namespace Koshenya.Forms.Controls.StateParametersUC
{
    partial class SleepStateParametersUC
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
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox4;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button button1;
            this.awakenAnimsListBox = new System.Windows.Forms.ListBox();
            this.animsComboBox3 = new System.Windows.Forms.ComboBox();
            this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.soundsComboBox = new System.Windows.Forms.ComboBox();
            this.animsComboBox2 = new System.Windows.Forms.ComboBox();
            this.fallAsleepAnimsListBox = new System.Windows.Forms.ListBox();
            this.animsComboBox1 = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            button4 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(this.awakenAnimsListBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(this.animsComboBox3);
            groupBox3.Location = new System.Drawing.Point(12, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(351, 109);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Awake";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(291, 52);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(41, 23);
            button4.TabIndex = 13;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(this.RemoveAwakenAnimButton_Click);
            // 
            // awakenAnimsListBox
            // 
            this.awakenAnimsListBox.FormattingEnabled = true;
            this.awakenAnimsListBox.Location = new System.Drawing.Point(6, 19);
            this.awakenAnimsListBox.Name = "awakenAnimsListBox";
            this.awakenAnimsListBox.Size = new System.Drawing.Size(279, 56);
            this.awakenAnimsListBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 85);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 13);
            label7.TabIndex = 10;
            label7.Text = "Animation:";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(291, 19);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(41, 23);
            button3.TabIndex = 9;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.AddAwakenAnimButton_Click);
            // 
            // animsComboBox3
            // 
            this.animsComboBox3.FormattingEnabled = true;
            this.animsComboBox3.Location = new System.Drawing.Point(97, 81);
            this.animsComboBox3.Name = "animsComboBox3";
            this.animsComboBox3.Size = new System.Drawing.Size(121, 21);
            this.animsComboBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(this.soundsComboBox);
            groupBox2.Controls.Add(this.animsComboBox2);
            groupBox2.Location = new System.Drawing.Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(351, 76);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sleeping";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(this.timeUnitComboBox);
            groupBox4.Controls.Add(this.numericUpDown);
            groupBox4.Location = new System.Drawing.Point(224, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(116, 49);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sleep time";
            // 
            // timeUnitComboBox
            // 
            this.timeUnitComboBox.FormattingEnabled = true;
            this.timeUnitComboBox.Items.AddRange(new object[] {
            "ms",
            "sec",
            "min"});
            this.timeUnitComboBox.SelectedIndex = 0;
            this.timeUnitComboBox.Location = new System.Drawing.Point(69, 18);
            this.timeUnitComboBox.Name = "timeUnitComboBox";
            this.timeUnitComboBox.Size = new System.Drawing.Size(41, 21);
            this.timeUnitComboBox.TabIndex = 30;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown.TabIndex = 18;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 13);
            label4.TabIndex = 9;
            label4.Text = "Sleep sound:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(6, 26);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(85, 13);
            label23.TabIndex = 8;
            label23.Text = "Sleep animation:";
            // 
            // soundsComboBox
            // 
            this.soundsComboBox.FormattingEnabled = true;
            this.soundsComboBox.Location = new System.Drawing.Point(97, 47);
            this.soundsComboBox.Name = "soundsComboBox";
            this.soundsComboBox.Size = new System.Drawing.Size(121, 21);
            this.soundsComboBox.TabIndex = 7;
            this.soundsComboBox.SelectedIndexChanged += new System.EventHandler(this.SoundsComboBox_SelectedIndexChanged);
            // 
            // animsComboBox2
            // 
            this.animsComboBox2.FormattingEnabled = true;
            this.animsComboBox2.Location = new System.Drawing.Point(97, 22);
            this.animsComboBox2.Name = "animsComboBox2";
            this.animsComboBox2.Size = new System.Drawing.Size(121, 21);
            this.animsComboBox2.TabIndex = 6;
            this.animsComboBox2.SelectedIndexChanged += new System.EventHandler(this.AnimsComboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(this.fallAsleepAnimsListBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(this.animsComboBox1);
            groupBox1.Location = new System.Drawing.Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(351, 109);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fall asleep";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(291, 52);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(41, 23);
            button2.TabIndex = 13;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.RemoveFallAsleepAnimButton_Click);
            // 
            // fallAsleepAnimsListBox
            // 
            this.fallAsleepAnimsListBox.FormattingEnabled = true;
            this.fallAsleepAnimsListBox.Location = new System.Drawing.Point(6, 19);
            this.fallAsleepAnimsListBox.Name = "fallAsleepAnimsListBox";
            this.fallAsleepAnimsListBox.Size = new System.Drawing.Size(279, 56);
            this.fallAsleepAnimsListBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 10;
            label2.Text = "Animation:";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(291, 19);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(41, 23);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.AddFallAsleepAnimButton_Click);
            // 
            // animsComboBox1
            // 
            this.animsComboBox1.FormattingEnabled = true;
            this.animsComboBox1.Location = new System.Drawing.Point(97, 81);
            this.animsComboBox1.Name = "animsComboBox1";
            this.animsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.animsComboBox1.TabIndex = 7;
            // 
            // SleepStateParametersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "SleepStateParametersUC";
            this.Size = new System.Drawing.Size(379, 316);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox awakenAnimsListBox;
        private System.Windows.Forms.ComboBox animsComboBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox soundsComboBox;
        private System.Windows.Forms.ComboBox animsComboBox2;
        private System.Windows.Forms.ListBox fallAsleepAnimsListBox;
        private System.Windows.Forms.ComboBox animsComboBox1;
        private System.Windows.Forms.ComboBox timeUnitComboBox;
    }
}
