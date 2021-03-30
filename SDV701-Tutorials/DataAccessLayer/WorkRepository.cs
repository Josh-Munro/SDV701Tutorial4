using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity;

namespace ArtGallery.DataAccessLayer
{
    public class WorkRepository : Repository, IWorkRepository
    {
        public WorkRepository(ModelContext context) : base(context)
        {
        }
        protected virtual IQueryable<Work> All
        {
            get
            {
                return Context.Set<Work>();
            }
        }
        public virtual void Add(Work instance)
        {
            if (instance != null)
            {
                Context.Set<Work>().Add(instance);
            }
        }
        public virtual Work Get(int id)
        {
            return All.FirstOrDefault(a => a.ID == id);
        }
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }
        public virtual void Delete(Work instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }
        public virtual void Update(Work instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Modified;
            }
        }
        public virtual IEnumerable<Work> List()
        {
            return All.ToList();
        }
   
    }
}

