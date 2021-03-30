using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.DataAccessLayer
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private ModelContext _context = new ModelContext();
        private IArtistRepository _artistRepository;
        private IWorkRepository _workRepository;

        public IArtistRepository ArtistRepository
        {
            get
            {
                if (_artistRepository == null)
                {
                    _artistRepository = new ArtistRepository(_context);
                }
                return _artistRepository;
            }
        }

        public IWorkRepository WorkRepository
        {
            get
            {
                if (_workRepository == null)
                {
                    _workRepository = new WorkRepository(_context);
                }
                return _workRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) { _context.Dispose(); }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
