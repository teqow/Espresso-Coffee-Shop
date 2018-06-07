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
                    new Coffee {  Name = "Espresso Coffee", Price = 2M, ShortDescription = "Our famous espresso coffee!", LongDescription = "Espresso (ess-PRESS-oh) is a full-flavored, concentrated form of coffee that is served in “shots.” It is made by forcing pressurized, hot water through very finely ground coffee beans. This process is called “pulling a shot.”.", ImageUrl = "https://drinks.seriouseats.com/images/20110615-caffe-corretto.jpg", ImageThumbnailUrl = "https://drinks.seriouseats.com/images/20110615-caffe-corretto.jpg" },
                    new Coffee { Name = "Cappuccino", Price = 3M, ShortDescription = "Our famous cappuccino coffee!", LongDescription = "s an espresso-based coffee drink that originated in Italy, and is traditionally prepared with double espresso, and steamed milk foam. Variations of the drink involve the use of cream instead of milk,and flavouring with cinnamon or chocolate powder. It is typically smaller in volume than a caffè latte, with a thicker layer of micro foam.", ImageUrl = "https://rawfactoryflavor.com/wp-content/uploads/2015/11/cappuccino.jpg", ImageThumbnailUrl = "https://rawfactoryflavor.com/wp-content/uploads/2015/11/cappuccino.jpg" }
                );
            }
            context.SaveChanges();
        }
    }
}
