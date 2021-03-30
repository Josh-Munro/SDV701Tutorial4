using ArtGallery.DataAccessLayer;
using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.BusinessLayer
{
    public class WorkService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Add(WorkModel work)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<WorkModel, Work>());
            IMapper mapper = new Mapper(config);
            var data = new Work();
            mapper.Map(work, data);
            _unitOfWork.WorkRepository.Add(data);
            _unitOfWork.Save();

            return data.ID;
        }

        public int Update(WorkModel work)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<WorkModel, Work>());
            IMapper mapper = new Mapper(config);
            var data = _unitOfWork.WorkRepository.Get(work.ID);
            mapper.Map(work, data);
            _unitOfWork.WorkRepository.Update(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfWork.WorkRepository.Delete(id);
            _unitOfWork.Save();
        }

        public IList<ArtistModel> List()
        {
            var artists = _unitOfWork.ArtistRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Work, ArtistModel>();
                cfg.CreateMap<Work, WorkModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<ArtistModel>();
            mapper.Map(artists, models);
            return models;
        }
       

    }
}
