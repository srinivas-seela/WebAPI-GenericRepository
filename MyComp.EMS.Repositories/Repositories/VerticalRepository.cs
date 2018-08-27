
using System.Collections.Generic;
using MyComp.EMS.Data.Interfaces;
using Entities = MyComp.EMS.Data.Entities;
using MyComp.EMS.Repositories;
using MyComp.EMS.Repositories.Interfaces;
using AutoMapper;
using MyComp.EMS.Repositories.Models;

namespace MyComp.EMS.Repositories.Repositories
{
    public class VerticalRepository : IVerticalRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper imapperip;
        private IMapper imapperop;
        
        public VerticalRepository(IUnitOfWork unitofWork)
        {            
            this._unitOfWork = unitofWork;

            var configip = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.Vertical,Entities.Vertical>();
            });
            var configop = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entities.Vertical, Models.Vertical>();
            });
            imapperip = configip.CreateMapper();
            imapperop = configop.CreateMapper();
        }
        public IEnumerable<Models.Vertical> GetVerticals()
        {
            IEnumerable<Entities.Vertical> verticalModels = _unitOfWork.Repository<Entities.Vertical>().GetAll();
            IEnumerable<Models.Vertical> verticals = imapperop.Map<IEnumerable<Entities.Vertical>, IEnumerable<Models.Vertical>>(verticalModels);
            return verticals;
        }
        public void AddVertical(Models.Vertical entity)
        {
            Entities.Vertical vertical = imapperip.Map<Models.Vertical, Entities.Vertical>(entity);
            _unitOfWork.Repository<Entities.Vertical>().Add(vertical);
            _unitOfWork.SaveChanges();
        }
        public void RemoveVertical(Models.Vertical entity)
        {
            Entities.Vertical vertical = imapperip.Map<Models.Vertical, Entities.Vertical>(entity);
            _unitOfWork.Repository<Entities.Vertical>().Remove(vertical);
            _unitOfWork.SaveChanges();
        }

        public Models.Vertical GetVerticalByID(int Id)
        {
            Entities.Vertical entity = _unitOfWork.Repository<Entities.Vertical>().GetSingle(x => x.VerticalID == Id);
            Models.Vertical vertical = imapperop.Map<Entities.Vertical, Models.Vertical>(entity);
            return vertical;
        }
       
    }
}
