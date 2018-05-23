using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Espresso.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Coffee World";

            var coffees = _coffeeRepository.GetAllCoffees().OrderBy(c => c.Name);

            var coffeeViewModel = new CoffeeViewModel()
            {
                Coffees = coffees.ToList(),
                Title = "Welcome to Esspreso Coffee"
            };

            return View(coffeeViewModel);
        }

        public IActionResult Details(int id)
        {
            var coffee = _coffeeRepository.GetCoffeeById(id);
            if (coffee == null)
                return NotFound();


            return View(coffee);
        }
    }
}