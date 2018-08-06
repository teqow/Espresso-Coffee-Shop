using Espresso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.ViewModels
{
    public class CoffeeViewModel
    {
        public IEnumerable<Coffee> Coffees { get; set; }
        public string Title { get; set; }
    }
}
