namespace ArtGallery.DataAccessLayer
{
    public interface IUnitOfWork
    {
        IArtistRepository ArtistRepository { get; }
        IWorkRepository WorkRepository { get; }

        void Dispose();
        void Save();
    }
}