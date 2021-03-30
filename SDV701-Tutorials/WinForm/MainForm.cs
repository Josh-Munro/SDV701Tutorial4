using System;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public sealed partial class MainForm : Form
    {   
        //Singleton
        private static readonly MainForm _instance = new MainForm();

        private ArtistList _artistList = new ArtistList();

        public delegate void Notify(string prGalleryName);

        public event Notify GalleryNameChanged;

        static MainForm()
        {
        }

        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm Instance
        {
            get { return _instance; }
        }

        private void UpdateTitle(string galleryName)
        {
            if (!string.IsNullOrEmpty(galleryName))
                Text = "Gallery - " + galleryName;
        }

        public void UpdateDisplay()
        {
            artistList.DataSource = null;
            string[] displayList = new string[_artistList.Count];
            _artistList.Keys.CopyTo(displayList, 0);
            artistList.DataSource = displayList;
            valueLabel.Text = Convert.ToString(_artistList.GetTotalValue());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArtistForm.Run(new Artist(_artistList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new artist");
            }
        }

        private void artistList_DoubleClick(object sender, EventArgs e)
        {
            string key;

            key = Convert.ToString(artistList.SelectedItem);
            if (key != null)
                try
                {
                    ArtistForm.Run(_artistList[key]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            try
            {
                _artistList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string key;

            key = Convert.ToString(artistList.SelectedItem);
            if (key != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    _artistList.Remove(key);
                    artistList.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting artist");
                }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _artistList = ArtistList.RetrieveArtistList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
            GalleryNameChanged += UpdateTitle;
            GalleryNameChanged(_artistList.GalleryName);
        }

        private void galleryNameButton_Click(object sender, EventArgs e)
        {
            _artistList.GalleryName = new InputBox("Enter Gallery Name:").Answer;
            GalleryNameChanged(_artistList.GalleryName);
        }
    }
}