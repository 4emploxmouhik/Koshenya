namespace Koshenya.Forms.Controls.StateParametersUC
{
    partial class PunchStateParametersUC
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
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label2;
            this.animsComboBox2 = new System.Windows.Forms.ComboBox();
            this.soundsComboBox2 = new System.Windows.Forms.ComboBox();
            this.soundsComboBox1 = new System.Windows.Forms.ComboBox();
            this.animsComboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(35, 125);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(135, 13);
            label21.TabIndex = 15;
            label21.Text = "Aggressive reaction sound:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(19, 98);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(151, 13);
            label22.TabIndex = 14;
            label22.Text = "Aggressive reaction animation:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(50, 47);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(120, 13);
            label20.TabIndex = 13;
            label20.Text = "Regular reaction sound:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(34, 16);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(136, 13);
            label19.TabIndex = 12;
            label19.Text = "Regular reaction animation:";
            // 
            // animsComboBox2
            // 
            this.animsComboBox2.FormattingEnabled = true;
            this.animsComboBox2.Location = new System.Drawing.Point(176, 94);
            this.animsComboBox2.Name = "animsComboBox2";
            this.animsComboBox2.Size = new System.Drawing.Size(121, 21);
            this.animsComboBox2.TabIndex = 11;
            this.animsComboBox2.SelectedIndexChanged += new System.EventHandler(this.AnimsComboBox2_SelectedIndexChanged);
            // 
            // soundsComboBox2
            // 
            this.soundsComboBox2.FormattingEnabled = true;
            this.soundsComboBox2.Location = new System.Drawing.Point(176, 121);
            this.soundsComboBox2.Name = "soundsComboBox2";
            this.soundsComboBox2.Size = new System.Drawing.Size(121, 21);
            this.soundsComboBox2.TabIndex = 10;
            this.soundsComboBox2.SelectedIndexChanged += new System.EventHandler(this.SoundsComboBox2_SelectedIndexChanged);
            // 
            // soundsComboBox1
            // 
            this.soundsComboBox1.FormattingEnabled = true;
            this.soundsComboBox1.Location = new System.Drawing.Point(176, 44);
            this.soundsComboBox1.Name = "soundsComboBox1";
            this.soundsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.soundsComboBox1.TabIndex = 9;
            this.soundsComboBox1.SelectedIndexChanged += new System.EventHandler(this.SoundsComboBox1_SelectedIndexChanged);
            // 
            // animsComboBox1
            // 
            this.animsComboBox1.FormattingEnabled = true;
            this.animsComboBox1.Location = new System.Drawing.Point(176, 13);
            this.animsComboBox1.Name = "animsComboBox1";
            this.animsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.animsComboBox1.TabIndex = 8;
            this.animsComboBox1.SelectedIndexChanged += new System.EventHandler(this.AnimsComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 168);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 13);
            label2.TabIndex = 17;
            label2.Text = "Punches to aggresive reaction:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(176, 166);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown.TabIndex = 18;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // PunchStateParametersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(label2);
            this.Controls.Add(label21);
            this.Controls.Add(label22);
            this.Controls.Add(label20);
            this.Controls.Add(label19);
            this.Controls.Add(this.animsComboBox2);
            this.Controls.Add(this.soundsComboBox2);
            this.Controls.Add(this.soundsComboBox1);
            this.Controls.Add(this.animsComboBox1);
            this.Name = "PunchStateParametersUC";
            this.Size = new System.Drawing.Size(321, 200);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox animsComboBox2;
        private System.Windows.Forms.ComboBox soundsComboBox2;
        private System.Windows.Forms.ComboBox soundsComboBox1;
        private System.Windows.Forms.ComboBox animsComboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
