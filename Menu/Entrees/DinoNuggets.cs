using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        public DinoNuggets()
        {
            ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
            price = 4.25;
            calories = 59;
            count = 6;
            add_price = 0.25;
            base_count = count;
        }

        public void AddNugget()
        {
            count += 1;
        }
    }
}
