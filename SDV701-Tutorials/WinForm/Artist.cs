using System;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class Artist
    {
        private string _name;
        private string _speciality;
        private string _phone;

        private WorkList _workList;
        private ArtistList _artistList;

        public Artist()
        {
        }

        public Artist(ArtistList artistList)
        {
            _workList = new WorkList();
            _artistList = artistList;
        }

        public bool IsDuplicate(string artistName)
        {
            return _artistList.ContainsKey(artistName);
        }

        public void NewArtist()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                _artistList.Add(Name, this);
            }
            else
            {
                throw new Exception("No artist name entered");
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Speciality
        {
            get { return _speciality; }
            set { _speciality = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public decimal TotalValue
        {
            get { return _workList.GetTotalValue(); /* was: _totalValue;*/ }
        }

        public ArtistList ArtistList
        {
            get { return _artistList; }
        }

        public WorkList WorksList
        {
            get { return _workList; }
        }
    }
}
