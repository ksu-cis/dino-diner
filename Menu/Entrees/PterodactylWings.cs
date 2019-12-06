/*  PterodactylWings.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
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
