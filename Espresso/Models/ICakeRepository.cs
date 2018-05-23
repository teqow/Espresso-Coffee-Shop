using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> GetAllCakes();

        Cake GetCakeById(int cakeId);
    }
}
