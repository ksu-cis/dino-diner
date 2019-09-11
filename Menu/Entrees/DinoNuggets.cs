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
            calories = 45;
            count = 6;
        }

        public void AddNugget()
        {
            count += 1;
        }
    }
}
