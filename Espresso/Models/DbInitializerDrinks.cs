using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class DbInitializerDrinks
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drinks { Name = "Good Mojito", Price = 3M, ShortDescription = "Mojito drink!", LongDescription = "Classic mojito for everyone! Just try it", ImageUrl = "https://www.simplyrecipes.com/wp-content/uploads/2017/06/mojito-vertical-a-1800.jpg", ImageThumbnailUrl = "https://www.simplyrecipes.com/wp-content/uploads/2017/06/mojito-vertical-a-1800.jpg "},
                    new Drinks { Name = "Aperol Spritz", Price = 6M, ShortDescription = "I love it!", LongDescription = "An Aperol Spritz is an aperitif cocktail consisting of prosecco, Aperol and soda water.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Aperol_Spritz_2014a.jpg/800px-Aperol_Spritz_2014a.jpg",ImageThumbnailUrl= "https://www.simplyrecipes.com/wp-content/uploads/2017/06/mojito-vertical-a-1800.jpg" }
                );
            }
            context.SaveChanges();
        }
    }
}
