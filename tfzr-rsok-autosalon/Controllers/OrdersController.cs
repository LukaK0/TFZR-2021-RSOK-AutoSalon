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
        public OrdersController(IOrdersService service, ICarsService carsService) : base(service)
        {
            _service = service;
            _carsService = carsService;
        }

        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model.ToList());
        }
        public IActionResult Accept(int id)
        {
            var model = _service.Get(id).CreateViewModel();
            model.Status = 1;
            _service.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Decline(int id)
        {
            var model = _service.Get(id).CreateViewModel();
            model.Status = 0;
            _service.Update(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var model = new Orders();
            var car = _carsService.Get(id).CreateViewModel();
            model.CarId = car.Id;
            model.Status = 0;
            model.DateOfPurchase = DateTime.Now;
            _service.Add(model);

            return RedirectToAction("Index");
        }
    }
}
