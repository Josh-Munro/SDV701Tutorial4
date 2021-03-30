using System;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public partial class InputBox : Form
    {
        private string _answer;

        public InputBox(string question)
        {
            InitializeComponent();
            questionLabel.Text = question;
            errorLabel.Text = "";
            answer.Focus();
            ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _answer = answer.Text;
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _answer; }
        }
    }
}