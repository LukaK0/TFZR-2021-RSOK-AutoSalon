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
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _repository;
        private readonly ICategorizesRepository _categorizes;
        private readonly IManufacturesRepository _manufactures;
        private readonly ICarModelsRepository _carModels;


        public CarsService(ICarsRepository repository, ICategorizesRepository categorizes, IManufacturesRepository manufactures, ICarModelsRepository carModels)
        {
            _repository = repository;
            _carModels = carModels;
            _categorizes = categorizes;
            _manufactures = manufactures;
        }
        public IEnumerable<CarsViewModel> GetAll()
        {
            return _repository.GetAll(includeProperties: "CarModels, Categorizes , Manufacturers").Select(x => new CarsViewModel(x).CreateViewModel());
        }

        public SelectList GetCategoryForDropDown()
        {
            return new SelectList(_categorizes.GetAll(), nameof(Categorizes.Id), nameof(Categorizes.Name));
        }

        public SelectList GetModelsForDropDown()
        {
            return new SelectList(_carModels.GetAll(), nameof(CarModels.Id), nameof(CarModels.Name));
        }

        public SelectList GetManufacturersForDropDown()
        {

            return new SelectList(_manufactures.GetAll(), nameof(Manufacturers.Id), nameof(Manufacturers.Name));
        }

        public IBaseViewModel<Cars> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Cars model)
        {
            _repository.Add(model);
        }
        
    }
}
