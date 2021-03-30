using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity;
namespace ArtGallery.DataAccessLayer
{
    public abstract class Repository
    {
        public Repository(ModelContext context)
        {
            Context = context;
        }

        protected ModelContext Context { get; private set; }
    }
}
