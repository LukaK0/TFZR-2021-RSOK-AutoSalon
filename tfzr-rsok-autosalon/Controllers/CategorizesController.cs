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
    public class CategorizesController : BaseController<Categorizes>
    {
        private new readonly ICategorizesService _service;
        public CategorizesController(ICategorizesService service) : base(service)
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
            var model = _service.Get(id) as CategorizesViewModel;
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.Get(id) as CategorizesViewModel;
            return View(model);
        }
    }
}
