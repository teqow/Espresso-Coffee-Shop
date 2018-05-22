using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class DbInitializerCoffees
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Coffees.Any())
            {
                context.AddRange
                (
                    new Coffee { Name = "Espresso Caffe", Price = 2M, ShortDescription = "Our famous espresso caffe!", LongDescription = "Espresso (ess-PRESS-oh) is a full-flavored, concentrated form of coffee that is served in “shots.” It is made by forcing pressurized, hot water through very finely ground coffee beans. This process is called “pulling a shot.”.", ImageUrl = "https://drinks.seriouseats.com/images/20110615-caffe-corretto.jpg", ImageThumbnailUrl = "https://drinks.seriouseats.com/images/20110615-caffe-corretto.jpg" }
                );
            }
            context.SaveChanges();
        }
    }
}
