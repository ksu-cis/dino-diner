/* SteakosaurusBurger.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the SteakosaurusBurger object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains pickles.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// This bool determines if the item contains ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// This bool determines if the item contains mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// This double has a getter and a setter to decide the price of the menu item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This unsigned integer gives the calorie count for this menu item. It has a getter and 
        /// a setter.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all the ingredients of the burger and allows the bun, pickles, ketchup,
        /// and mustard to be removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if (pickle)
                {
                    ingredients.Add("Pickle");
                }
                if (ketchup)
                {
                    ingredients.Add("Ketchup");
                }
                if (mustard)
                {
                    ingredients.Add("Mustard");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// This method allows the user to remove the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This method allows the user to remove the pickles.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// This method allows the user to remove the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// This method allows the user to remove the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
