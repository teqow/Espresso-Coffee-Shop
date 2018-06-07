using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Espresso.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinksRepository _drinksRepostiory;

        public DrinksController(IDrinksRepository drinksRepostiory)
        {
            _drinksRepostiory = drinksRepostiory;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Drinks World";

            var drinks = _drinksRepostiory.GetAllDrinks().OrderBy(d => d.Name);

            var drinksViewModel = new DrinksViewModel()
            {
                Drinks = drinks.ToList(),
                Title = "Welcome to our drinks menu"
            };

            return View(drinksViewModel);
        }

        public IActionResult Details(int id)
        {
            var drinks = _drinksRepostiory.GetDrinksById(id);
            if (drinks == null)
                return NotFound();


            return View(drinks);
        }
    }
}