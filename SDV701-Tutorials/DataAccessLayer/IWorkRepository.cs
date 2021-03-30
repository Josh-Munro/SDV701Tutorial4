using System.Collections;
using System.Collections.Generic;

namespace ArtGallery.DataAccessLayer
{
    public interface IWorkRepository
    {
        void Add(Work instance);
        void Delete(Work instance);
        void Delete(int id);
        Work Get(int id);
        IEnumerable<Work> List();
        void Update(Work instance);
    }
}