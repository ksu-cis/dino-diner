/*  PrehistoricPBJ.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool peanutButter = true;

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool jelly = true;

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
