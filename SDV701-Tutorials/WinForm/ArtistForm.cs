using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public partial class ArtistForm : Form
    {
        private Artist _artist;
        private WorkList _workList;

        private static Dictionary<Artist, ArtistForm> _artistFormList = new Dictionary<Artist, ArtistForm>();

        private ArtistForm()
        {
            InitializeComponent();
        }

        public static void Run(Artist artist)
        {
            ArtistForm artistForm;
            if (!_artistFormList.TryGetValue(artist, out artistForm))
            {
                artistForm = new ArtistForm();
                _artistFormList.Add(artist, artistForm);
                artistForm.SetDetails(artist);
            }
            else
            {
                artistForm.Show();
                artistForm.Activate();
            }
        }

        private void UpdateTitle(string galleryName)
        {
            if (!string.IsNullOrEmpty(galleryName))
                Text = "Artist Details - " + galleryName;
        }

        private void UpdateDisplay()
        {
            if (_workList.SortOrder == 0)
            {
                _workList.SortByName();
                byName.Checked = true;
            }
            else
            {
                _workList.SortByDate();
                byDate.Checked = true;
            }

            workList.DataSource = null;
            workList.DataSource = _workList;
            totalLabel.Text = Convert.ToString(_workList.GetTotalValue());
        }

        public void UpdateForm()
        {
            name.Text = _artist.Name;
            speciality.Text = _artist.Speciality;
            phone.Text = _artist.Phone;
            _workList = _artist.WorksList;

            //MainForm.Instance.GalleryNameChanged += new MainForm.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        public void SetDetails(Artist artist)
        {
            _artist = artist;
            name.Enabled = string.IsNullOrEmpty(_artist.Name);
            UpdateForm();
            UpdateDisplay();
            MainForm.Instance.GalleryNameChanged += new MainForm.Notify(UpdateTitle);
            UpdateTitle(_artist.ArtistList.GalleryName);
            Show();
        }

        private void PushData()
        {
            _artist.Name = name.Text;
            _artist.Speciality = speciality.Text;
            _artist.Phone = phone.Text;
            //_workList.SortOrder = _sortOrder; // no longer required, updated with each byDate_CheckedChanged
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string reply = new InputBox(Work.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(reply))
            {
                _workList.AddWork(reply[0]);
                UpdateDisplay();
                MainForm.Instance.UpdateDisplay();
            }
        }

        private void workList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _workList.EditWork(workList.SelectedIndex);
                UpdateDisplay();
                MainForm.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = workList.SelectedIndex;

            if (index >= 0 && MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _workList.RemoveAt(index);
                UpdateDisplay();
                MainForm.Instance.UpdateDisplay();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
                try
                {
                    PushData();
                    if (name.Enabled)
                    {
                        _artist.NewArtist();
                        MessageBox.Show("Artist added!", "Success");
                        MainForm.Instance.UpdateDisplay();
                        name.Enabled = false;
                    }
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private Boolean IsValid()
        {
            if (name.Enabled && name.Text != "")
                if (_artist.IsDuplicate(name.Text))
                {
                    MessageBox.Show("Artist with that name already exists!", "Error adding artist");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void byDate_CheckedChanged(object sender, EventArgs e)
        {
            _workList.SortOrder = Convert.ToByte(byDate.Checked);
            UpdateDisplay();
        }

    }
}