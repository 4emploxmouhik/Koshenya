using System;
using System.Windows.Forms;

namespace Koshenya.Forms
{
    public partial class ExceptionInfoForm : Form
    {
        public ExceptionInfoForm()
        {
            InitializeComponent();
        }

        public ExceptionInfoForm(Exception ex) : this()
        {
            exceptionTextBox.Text = ex.GetType().Name;
            messageTextBox.Text = ex.Message;
            stackTraceTextBox.Text = ex.StackTrace;
        }

        public static void Show(Exception ex)
        {
            new ExceptionInfoForm(ex).ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
