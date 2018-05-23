using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class DbInitializerCakes
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cakes.Any())
            {
                context.AddRange
                (
                    new Cake { Name = "Cheesecake", Price = 2M, ShortDescription ="Sweet Dessert!", LongDescription = "Cheesecake is a sweet dessert consisting of one or more layers. The main, and thickest layer, consists of a mixture of soft, fresh cheese (typically cream cheese or ricotta), eggs, vanilla and sugar; if there is a bottom layer it often consists of a crust or base made from crushed cookies (or digestive biscuits), graham crackers, pastry, or sponge cake.[1] It may be baked or unbaked (usually refrigerated). Cheesecake is usually sweetened with sugar and may be flavored or topped with fruit, whipped cream, nuts, cookies, fruit sauce, or chocolate syrup. Cheesecake can be prepared in many flavors, such as strawberry, pumpkin, key lime, lemon, chocolate, Oreo, chestnut, or toffee.", ImageUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2013/12/9/0/FNK_Cheesecake_s4x3.jpg.rend.hgtvcom.616.462.suffix/1387411272847.jpeg" },
                    new Cake { Name = "Cake with nuts", Price= 2.50M, ShortDescription ="I love it!", LongDescription = "Combine the almonds, Brazil nuts, walnuts, pecans, dates, red and green cherries; mix well. Sift together the flour, sugar, baking powder and salt. Combine with nut mixture and mix well. Beat eggs and vanilla, add to nut and flour mixture and mix well." , ImageUrl = "https://img.taste.com.au/bdMi-7Sb/taste/2016/11/celebration-fruit-and-nut-cake-60695-1.jpeg" }
                );
            }
            context.SaveChanges();
        }
    }
}
