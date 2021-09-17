using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;

namespace tfzr_rsok_autosalon.Controllers
{
    public class OrdersController : BaseController<Orders>
    {
        private new readonly IOrdersService _service;
        private readonly ICarsService _carsService;
        private readonly ICarModelsService _carModelsService;
        private readonly ICategorizesService _categorizesService;
        private readonly IManufacturersService _manufacturersService;
        public OrdersController(IOrdersService service, ICarsService carsService, ICarModelsService carModelsService,
            ICategorizesService categorizesService, IManufacturersService manufacturersService) : base(service)
        {
            _service = service;
            _carsService = carsService;
            _carModelsService = carModelsService;
            _categorizesService = categorizesService;
            _manufacturersService = manufacturersService;
        }

        public IActionResult Index()
        {
            var model = _service.GetAll().ToList();

            foreach (var x in model)
            {
                x.Model.Car = _carsService.GetModel(x.Model.CarId);
            }

            return View("Index", model);
        }
        public IActionResult Accept(int id)
        {
            var model = _service.GetModel(id);
            model.Car = _carsService.GetModel(model.CarId);
            model.CarId = model.Car.Id;
            model.Status = 1;
            _service.Update(model);

            var models = _service.GetAll().ToList();

            return View("Index", models);
        }
        public IActionResult Decline(int id)
        {
            var model = _service.GetModel(id);
            model.Car = _carsService.GetModel(model.CarId);
            model.CarId = model.Car.Id;
            model.Status = 0;
            _service.Update(model);

            var models = _service.GetAll().ToList();

            return View("Index", models);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var model = new Orders();
            model.Car = _carsService.GetModel(id);
            model.CarId = model.Car.Id;
            model.Status = 0;
            model.DateOfPurchase = DateTime.Now;
            _service.Add(model);

            var models = _service.GetAll().ToList();

            return View("Index", models);
        }
    }
}
