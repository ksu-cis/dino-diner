/*  VelociWrap.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool lettuce = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool dressing = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool cheese = true;

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");

                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
