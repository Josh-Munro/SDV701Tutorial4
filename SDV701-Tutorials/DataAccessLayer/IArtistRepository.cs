using System.Collections;
using System.Collections.Generic;

namespace ArtGallery.DataAccessLayer
{
    public interface IArtistRepository
    {
        void Add(Artist instance);
        void Delete(Artist instance);
        void Delete(int id);
        Artist Get(int id);
        IEnumerable<Artist> List();
        IEnumerable ListNames();
        void Update(Artist instance);
    }
}