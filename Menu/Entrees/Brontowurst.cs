/* Brontowurst.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the Brontowurst object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// This bool determines if the item contains onions.
        /// </summary>
        private bool onions = true;

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
        /// This list contains all the ingredients of the Brontowurst and allows the bun, peppers,
        /// and onions to be removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> {"Brautwurst"};
                if(bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if(peppers)
                {
                    ingredients.Add("Peppers");
                }
                if(onions)
                {
                    ingredients.Add("Onion");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// This method allows the user to remove the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This method allows the user to remove the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// This method allows the user to remove the onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
