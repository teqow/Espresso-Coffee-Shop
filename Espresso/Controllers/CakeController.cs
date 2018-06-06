using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;


        public CakeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public IActionResult Index()
        {
            var cakes = _cakeRepository.GetAllCakes().OrderBy(c => c.Name);

            var cakeViewModel = new CakeViewModel()
            {
                Cakes = cakes.ToList(),
                Title = "Welcome to our delicious cakes"
            };

            return View(cakeViewModel);
        }

        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);

            if (cake == null)
                return NotFound();


            return View(cake);

        }
    }
}
