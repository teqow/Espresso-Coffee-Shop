using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public interface IDrinksRepository
    {
        IEnumerable<Drinks> GetAllDrinks();

        Drinks GetDrinksById(int drinksId);
    }
}
