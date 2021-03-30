using System;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class Photograph : Work
    {
        private float _width;
        private float _height;
        private string _type;

        public delegate void LoadPhotographFormDelegate(Photograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        public override void EditDetails()
        {
            LoadPhotographForm(this);
        }

        public Single Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Single Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
