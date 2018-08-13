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

        public void AddCake(Cake cake)
        {
            _appDbContext.Add(cake);
            return;
        }

        public IEnumerable<Cake> GetAllCakes()
        {
            return _appDbContext.Cakes;
        }

        public Cake GetCakeById(int cakeId)
        {
            return _appDbContext.Cakes.FirstOrDefault(c => c.Id == cakeId);
        }

        public void SaveCake(Cake cake)
        {
            _appDbContext.Cakes.Add(cake);
            _appDbContext.SaveChanges();

        }

        public Cake DeleteCake(int cakeId)
        {
            Cake dbCake = _appDbContext.Cakes.FirstOrDefault(c => c.Id == cakeId);

            if (dbCake != null)
            {
                _appDbContext.Cakes.Remove(dbCake);
                _appDbContext.SaveChanges();
            }

            return dbCake;
        }
    }
}
