using System;
using System.Collections.Generic;

 namespace ArtGallery.WinForm
{
    sealed class NameComparer : IComparer<Work>
    {
        //Singleton
        private static readonly NameComparer _instance = new NameComparer();

        static NameComparer()
        {
        }

        private NameComparer()
        {
        }

        public static NameComparer Instance => _instance;

        public int Compare(Work x, Work y)
        {
            Work workClassX = x;
            Work workClassY = y;
            string nameX = workClassX.Name;
            string nameY = workClassY.Name;

            return nameX.CompareTo(nameY);
        }
    }
}
