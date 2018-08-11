using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CoffeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Coffee DeleteCoffee(int coffeeId)
        {
            Coffee dbCoffee = _appDbContext.Coffees.FirstOrDefault(c => c.Id == coffeeId);
            if (dbCoffee != null)
            {
                _appDbContext.Coffees.Remove(dbCoffee);
                _appDbContext.SaveChanges();
            }

            return dbCoffee;
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
             return _appDbContext.Coffees;
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _appDbContext.Coffees.FirstOrDefault(c => c.Id == coffeeId);
        }

        public void SaveCoffe(Coffee coffee)
        {
            _appDbContext.Coffees.Add(coffee);
            _appDbContext.SaveChanges();
        }


    }
}
