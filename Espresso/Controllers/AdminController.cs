using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Espresso.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public AdminController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

   
        [HttpGet]
        public IActionResult Index() => View(_coffeeRepository.GetAllCoffees());

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var coffee = _coffeeRepository.GetCoffeeById(id);

            return View(coffee);
        }

        [HttpPost]
        public IActionResult Edit(Coffee coffee)
        {
            if (ModelState.IsValid)
            {
                _coffeeRepository.SaveCoffe(coffee);
                TempData["message"] = $"Zapisano {coffee.Name}";
                return RedirectToAction("Index");
            }
            else
            {
                return View(coffee);
            }
        }
    }
}



