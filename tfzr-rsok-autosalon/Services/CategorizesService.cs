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
    public class CategorizesService : ICategorizesService
    {
        private readonly ICategorizesRepository _repository;


        public CategorizesService(ICategorizesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CategorizesViewModel> GetAll()
        {
            return _repository.GetAll().Select(x => new CategorizesViewModel(x).CreateViewModel());
        }

        public IBaseViewModel<Categorizes> Get(int id)
        {
            return new CategorizesViewModel(_repository.Get(id));
        }

        public void Update(Categorizes model)
        {
            _repository.Update(model);
        }

        public void Delete(int id)
        {
            _repository.Remove(_repository.Get(id));
        }

        public void Add(Categorizes model)
        {
            _repository.Add(model);
        }
    }
}
