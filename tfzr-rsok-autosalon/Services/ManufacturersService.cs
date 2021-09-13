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
            return _repository.Get(id) as IBaseViewModel<Manufacturers>;
        }

        public void Update(Manufacturers model)
        {
            _repository.Update(model);
        }

        public void Delete(int id)
        {
            _repository.Remove(_repository.Get(id));
        }

        public void Add(Manufacturers model)
        {
            _repository.Add(model);
        }
    }
}
