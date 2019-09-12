/*  Brontowurst.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        ///<Summary>
        /// Price of this entree.
        ///</Summary>
        public double Price { get; set; }

        ///<Summary>
        /// Number of calories in this entree.
        ///</Summary>
        public uint Calories { get; set; }

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
