/* PterodactylWings.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the PterodactylWings object and its menu specifications, including its 
    /// calories, price, and ingredients. No ingredients are changed.
    /// </summary>
    public class PterodactylWings
    {
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
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
