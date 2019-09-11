using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() {"Chicken","Wing Sauce" };
                return Ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
