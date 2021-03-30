using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class ArtistList : SortedDictionary<string, Artist>
    {
        private const string _fileName = "gallery.dat";
        private string _galleryName;

        public void NewArtist(Artist artist)
        {
            if (!string.IsNullOrEmpty(artist.Name))
            {
                Add(artist.Name, artist);
            }
            else
            {
                throw new Exception("No artist name entered");
            }
        }

        public decimal GetTotalValue()
        {
            decimal total = 0;
            foreach (Artist artist in Values)
            {
                total += artist.TotalValue;
            }
            return total;
        }

        public string GalleryName
        {
            get { return _galleryName; }
            set { _galleryName = value; }
        }
 
        public static ArtistList RetrieveArtistList()
        {
            ArtistList artistList;
            try
            {
                System.IO.FileStream fileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                artistList = (ArtistList)formatter.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                artistList = new ArtistList();
                throw new Exception("File Retrieve Error: " + ex.Message);
            }
            finally
            {

            }
            return artistList;
        }

        public void Save()
        {
            System.IO.FileStream fileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);
            fileStream.Close();
        }
    }
}
