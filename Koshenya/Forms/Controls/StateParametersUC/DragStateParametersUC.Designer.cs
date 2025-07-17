namespace Koshenya.Forms.Controls.StateParametersUC
{
    partial class DragStateParametersUC
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.sleepAnimComboBox = new System.Windows.Forms.ComboBox();
            this.animComboBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 13);
            label3.TabIndex = 13;
            label3.Text = "Animation when sleep:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(71, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 12;
            label2.Text = "Animation:";
            // 
            // sleepAnimComboBox
            // 
            this.sleepAnimComboBox.FormattingEnabled = true;
            this.sleepAnimComboBox.Location = new System.Drawing.Point(133, 42);
            this.sleepAnimComboBox.Name = "sleepAnimComboBox";
            this.sleepAnimComboBox.Size = new System.Drawing.Size(121, 21);
            this.sleepAnimComboBox.TabIndex = 11;
            this.sleepAnimComboBox.SelectedIndexChanged += new System.EventHandler(this.SleepAnimComboBox_SelectedIndexChanged);
            // 
            // animComboBox
            // 
            this.animComboBox.FormattingEnabled = true;
            this.animComboBox.Location = new System.Drawing.Point(133, 11);
            this.animComboBox.Name = "animComboBox";
            this.animComboBox.Size = new System.Drawing.Size(121, 21);
            this.animComboBox.TabIndex = 10;
            this.animComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimComboBox_SelectedIndexChanged);
            // 
            // DragStateParametersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.sleepAnimComboBox);
            this.Controls.Add(this.animComboBox);
            this.Name = "DragStateParametersUC";
            this.Size = new System.Drawing.Size(269, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sleepAnimComboBox;
        private System.Windows.Forms.ComboBox animComboBox;
    }
}
