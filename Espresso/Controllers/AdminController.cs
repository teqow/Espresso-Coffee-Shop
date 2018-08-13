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
    //Do not forget
    //Login= Administrator
    //Password= Secret123!
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly ICakeRepository _cakeRepository;
        private readonly IDrinksRepository _drinksRepository;

        public AdminController(ICoffeeRepository coffeeRepository, ICakeRepository cakeRepository, IDrinksRepository drinksRepository)
        {
            _coffeeRepository = coffeeRepository;
            _cakeRepository = cakeRepository;
            _drinksRepository = drinksRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var coffes = _coffeeRepository.GetAllCoffees();
            var cakes = _cakeRepository.GetAllCakes();
            var drinks = _drinksRepository.GetAllDrinks();

            var adminViewModel = new AdminViewModel()
            {
                Coffees = coffes.ToList(),
                Cakes = cakes.ToList(),
                Drinkses = drinks.ToList()
                
            };

            return View(adminViewModel);
        }


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

        public ViewResult Create() => View("Edit", new Coffee());

        [HttpPost]
        public IActionResult Delete(int coffeeId)
        {
            Coffee deleteCoffee= _coffeeRepository.DeleteCoffee(coffeeId);
            if (deleteCoffee != null)
            {
                TempData["message"] = $"Usunięto {deleteCoffee.Name}.";
            }

            return RedirectToAction("Index");
        }
    }
}



