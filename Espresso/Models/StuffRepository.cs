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
                new Stuff { Id = 1 , Name = "Our Coffees",ImageUrl = "https://www.healthline.com/hlcmsresource/images/AN_images/espresso-ground-coffee-beans-1296x728.jpg"},
                new Stuff { Id = 2 , Name = "Our Cakes", ImageUrl ="https://s3.przepisy.pl/przepisy3ii/img/variants/767x0/mus-z-trzech-czekolad342648.jpg"}
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
