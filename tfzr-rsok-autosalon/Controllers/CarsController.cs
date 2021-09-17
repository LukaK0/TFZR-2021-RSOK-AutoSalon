using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Controllers
{
    public class CarsController : BaseController<Cars>
    {
        private new readonly ICarsService _service;
        public CarsController(ICarsService service) : base(service)
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

        public IActionResult Details(int id)
        {
            var model = _service.GetDetails(id);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.Get(id) as CarsViewModel;
            return View(model);
        }
    }
}
