using System;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public partial class WorkForm : Form
    {
        protected Work _work;

        public WorkForm()
        {
            InitializeComponent();
        }

        public void SetDetails(Work work)
        {
            _work = work;
            UpdateForm();
            ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                PushData();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool IsValid()
        {
            return true;
        }

        protected virtual void UpdateForm()
        {
            name.Text = _work.Name;
            creation.Text = _work.Date.ToShortDateString();
            value.Text = _work.Value.ToString();
        }

        protected virtual void PushData()
        {
            _work.Name = name.Text;
            _work.Date = DateTime.Parse(creation.Text);
            _work.Value = decimal.Parse(value.Text);
        }

    }
}