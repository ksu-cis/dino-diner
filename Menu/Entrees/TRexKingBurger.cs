using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Creates a new TRexKingBurger Instance. 
        /// </summary>
        public TRexKingBurger()
        {
            ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie", "Lettuce", "Tomato", "Onion", "Pickle", "Ketchup", "Mustard", "Mayo" };
            price = 8.45;
            calories = 728;
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
        /// Removes the lettuce from the burger.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Removes the tomato from the burger.
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Removes the onion from the burger.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Removes the pickle from the burger.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes the ketchup from the burger.
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
        
        /// <summary>
        /// Removes the mayo from the burger
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }
    }
}
