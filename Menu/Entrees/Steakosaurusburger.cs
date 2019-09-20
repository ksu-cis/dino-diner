using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Creates a new SteakosaurusBurger.
        /// </summary>
        public SteakosaurusBurger()
        {
            ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Pickle", "Ketchup", "Mustard" };
            price = 5.15;
            calories = 621;
            count = 1;
        }

        /// <summary>
        /// Removes the bun from the burger.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Removes the pickle from the burger
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes the ketchup from the burger
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes the mustard from the burger.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }
    }
}
