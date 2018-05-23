using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class CakeRepository : ICakeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Cake> GetAllCakes()
        {
            return _appDbContext.Cakes;
        }

        public Cake GetCakeById(int cakeId)
        {
            return _appDbContext.Cakes.FirstOrDefault(c => c.Id == cakeId);
        }
    }
}
