using System;
using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class WorkList : List<Work>
    {
        private byte _sortOrder;

        public void AddWork(char choice)
        {
            Work work = Work.NewWork(choice);
            if (work != null)
            {
                Add(work);
            }
        }

        public void EditWork(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                Work work = this[index];
                work.EditDetails();
            }
            else
                throw new Exception("Sorry no work selected #" + Convert.ToString(index));
        }

        public decimal GetTotalValue()
        {
            decimal total = 0;
            foreach (Work work in this)
            {
                total += work.Value;
            }
            return total;
        }

        public void SortByName()
        {
            Sort(NameComparer.Instance);
            _sortOrder = 0;
        }

        public void SortByDate()
        {
            Sort(DateComparer.Instance);
            _sortOrder = 1;
        }

        public byte SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }
    }
}
