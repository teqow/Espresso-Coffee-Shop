﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public interface ICoffeeRepository
    {
        IEnumerable<Coffee> GetAllCoffees();

        Coffee GetCoffeeById(int coffeeId);

        void SaveCoffe(Coffee coffee);

        Coffee DeleteCoffee(int coffeeId);
    }
}
