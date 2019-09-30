using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Creates a new VelociWrap Instance.
        /// </summary>
        public VelociWrap()
        {
            ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
            price = 6.86;
            calories = 356;
            count = 1;
        }

        /// <summary>
        /// Removes the dressing 
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        /// <summary>
        /// Removes the Lettuce 
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes the Cheese 
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }
    }
}
