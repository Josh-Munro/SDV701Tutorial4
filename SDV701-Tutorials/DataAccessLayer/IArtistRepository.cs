using System.Collections;
using System.Collections.Generic;

namespace ArtGallery.DataAccessLayer
{
    public interface IArtistRepository
    {
        void Add(Work instance);
        void Delete(Work instance);
        void Delete(int id);
        Work Get(int id);
        IEnumerable<Work> List();
        IEnumerable ListNames();
        void Update(Work instance);
    }
}