using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;

        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public HomeController(IProductService productService,
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _productService = productService;

            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {

            ViewBag.message1 = "First Instance " + _transientService1.GetID().ToString();
            ViewBag.message2 = "Second Instance " + _transientService2.GetID().ToString();

            ViewBag.message3 = "First Instance " + _scopedService1.GetID().ToString();
            ViewBag.message4 = "Second Instance " + _scopedService2.GetID().ToString();

            ViewBag.message5 = "First Instance " + _singletonService1.GetID().ToString();
            ViewBag.message6 = "Second Instance " + _singletonService2.GetID().ToString();

            return View(_productService.GetAll());
        }
    }
}
