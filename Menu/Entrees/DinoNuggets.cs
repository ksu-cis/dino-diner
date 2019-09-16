using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Creates a DinoNugget object. Price: $4.25, Calories per Nugget: 59, Count: 6
        /// </summary>
        public DinoNuggets()
        {
            ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
            price = 4.25;
            calories = 59;
            count = 6;
            add_price = 0.25;
            base_count = count;
        }

        /// <summary>
        /// Adds a new nugget.
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add( "Chicken Nugget" );
            count += 1;
        }
    }
}
