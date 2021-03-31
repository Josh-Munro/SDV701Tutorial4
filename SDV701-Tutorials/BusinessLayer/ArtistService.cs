using ArtGallery.DataAccessLayer;
using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.Models;

namespace ArtGallery.BusinessLayer
{
    public class ArtistService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArtistService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public int Add(ArtistModel artist) {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ArtistModel, Artist>().ForMember(x => x.Works, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Artist();
            mapper.Map(artist, data);
            _unitOfWork.ArtistRepository.Add(data);
            _unitOfWork.Save();

            return data.ID;
        }

        public int Update(ArtistModel artist) { 
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ArtistModel, Artist>().ForMember(x => x.Works, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfWork.ArtistRepository.Get(artist.ID);
            mapper.Map(artist, data);
            _unitOfWork.ArtistRepository.Update(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public void Delete(int id) {
            _unitOfWork.ArtistRepository.Delete(id);
            _unitOfWork.Save();
        }

        public IList<ArtistModel> List()
        {
            var artists = _unitOfWork.ArtistRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Artist, ArtistModel>();
                cfg.CreateMap<Work, WorkModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<ArtistModel>();
            mapper.Map(artists, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfWork.ArtistRepository.ListNames();
        }

    }
}
