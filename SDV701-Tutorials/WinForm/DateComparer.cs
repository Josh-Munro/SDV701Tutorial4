using System;
using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public sealed class DateComparer : IComparer<Work>
    {   
        //Singleton
        private static readonly DateComparer _instance = new DateComparer();

        static DateComparer()
        {
        }

        private DateComparer()
        {
        }

        public static DateComparer Instance => _instance;

        public int Compare(Work x, Work y)
        {
            Work workX = x;
            Work workY = y;
            DateTime dateX = workX.Date.Date;
            DateTime dateY = workY.Date.Date;

            return dateX.CompareTo(dateY);
        }
    }
}
