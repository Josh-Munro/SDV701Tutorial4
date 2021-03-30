﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.DataAccessLayer
{
    public class ArtistRepository : Repository, IArtistRepository
    
    {
        public ArtistRepository(ModelContext context) : base(context)
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
        //public void Save()
        //{
        //    Context.SaveChanges();
        //}
        public virtual IEnumerable<Work> List()
        {
            return All.ToList();
        }
        public virtual IEnumerable ListNames()
        {
            var query = from artist in All
                        select new { artist.ID, artist.Name };
            return query.ToList();
        }
    }
}