using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class StuffRepository : IStuffRepository
    {
        private List<Stuff> _stuffs;

        public StuffRepository()
        {
            if (_stuffs == null)
            {
                InitializeStuffs();
            }
        }
        private void InitializeStuffs()
        {
            _stuffs = new List<Stuff>
            {
                new Stuff { Id = 1 , Name = "Our Coffees",ImageUrl = "https://www.visafranchise.com/wp-content/uploads/2017/09/Coffee-Photo-1.jpg"},
                new Stuff { Id = 2 , Name = "Our Cakes", ImageUrl ="https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe_images/recipe-image-legacy-id--1956_11.jpg?itok=_8PNgmrc"}
            };
        }

        public IEnumerable<Stuff> GetAllStuff()
        {
            return _stuffs;
        }

        public Stuff GetAllStuffById(int stuffId)
        {
            return _stuffs.FirstOrDefault(p => p.Id == stuffId);
        }
    }
}
