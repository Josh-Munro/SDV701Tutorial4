using System;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public abstract class Work
    {
        private string _name;
        private DateTime _date = DateTime.Now;
        private decimal _value;

        public Work()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter P for Painting, S for Sculpture and H for Photograph";

        public static Work NewWork(char choice)
        {
            switch (char.ToUpper(choice))
            {
                case 'P': return new Painting();
                case 'S': return new Sculpture();
                case 'H': return new Photograph();
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _name + "\t" + _date.ToShortDateString();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }


    }
}
