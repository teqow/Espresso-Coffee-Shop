using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class DrinksRepository : IDrinksRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinksRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drinks> GetAllDrinks()
        {
            return _appDbContext.Drinks;
        }

        public Drinks GetDrinksById(int drinksId)
        {
            return _appDbContext.Drinks.FirstOrDefault(d => d.Id == drinksId);
        }
    }
}
