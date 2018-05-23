using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Espresso.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStuffRepository _stuffRepository;

        public HomeController(IStuffRepository stuffRepository)
        {
            _stuffRepository = stuffRepository;
        }
        public IActionResult Index()
        {
            var stuffs = _stuffRepository.GetAllStuff().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Stuffs = stuffs.ToList(),
                Title = "Our Menu",

            };
            return View(homeViewModel);
        }

    }
}
