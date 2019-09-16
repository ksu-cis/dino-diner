using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Creates a new PterodactylWings instance.
        /// </summary>
        public PterodactylWings()
        {
            ingredients = new List<string>() { "Chicken", "Wing Sauce" };
            price = 7.21;
            calories = 318;
            count = 1;
        }
        
    }
}
