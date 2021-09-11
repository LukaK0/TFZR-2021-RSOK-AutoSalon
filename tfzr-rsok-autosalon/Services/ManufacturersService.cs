using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services
{
    public class ManufacturersService : IManufacturersService
    {
        private readonly IManufacturesRepository _repository;


        public ManufacturersService(IManufacturesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ManufacturersViewModel> GetAll()
        {
            return _repository.GetAll().Select(x => new ManufacturersViewModel(x).CreateViewModel());
        }

        public IBaseViewModel<Manufacturers> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Manufacturers model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Manufacturers model)
        {
            _repository.Add(model);
        }

        IBaseViewModel<Manufacturers> IService<Manufacturers, IBaseViewModel<Manufacturers>>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
