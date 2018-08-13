using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Espresso.Models;

namespace Espresso.ViewModels
{
    public class AdminViewModel
    {
        public List<Coffee> Coffees { get; set; }
        public List<Cake> Cakes { get; set; }
        public List<Drinks> Drinkses { get; set; }
    }
}
