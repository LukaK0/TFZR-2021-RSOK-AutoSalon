using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;

namespace tfzr_rsok_autosalon.Controllers
{
    public class ManufacturersController : BaseController<Manufacturers>
    {
        private new readonly IManufacturersService _service;
        public ManufacturersController(IManufacturersService service) : base(service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var model = _service.Get(id) as ManufacturersViewModel;
            return View(model);
        }
    }
}
