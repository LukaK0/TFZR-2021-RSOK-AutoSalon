using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services
{
    public class CarModelsService : ICarModelsService
    {
        private readonly ICarModelsRepository _repository;
        private readonly ICategorizesRepository _categorizes;
        private readonly IManufacturesRepository _manufactures;

        public CarModelsService(ICategorizesRepository categorizes, IManufacturesRepository manufactures, ICarModelsRepository repository)
        {
            _repository = repository;
            _categorizes = categorizes;
            _manufactures = manufactures;
        }
        public IEnumerable<CarModelsViewModel> GetAll()
        {
            return _repository.GetAll(includeProperties: "Category, Manufacturer").Select(x => new CarModelsViewModel(x).CreateViewModel());
        }

        public SelectList GetCategoryForDropDown()
        {
            return new SelectList(_categorizes.GetAll(), nameof(Categorizes.Id), nameof(Categorizes.Name));
        }

        public SelectList GetManufacturersForDropDown()
        {

            return new SelectList(_manufactures.GetAll(), nameof(Manufacturers.Id), nameof(Manufacturers.Name));
        }

        public IBaseViewModel<CarModels> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CarModels model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(CarModels model)
        {
            _repository.Add(model);
        }
    }
}
