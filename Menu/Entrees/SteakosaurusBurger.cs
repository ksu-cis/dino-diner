/*  SteakosaurusBurger.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool bun = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool pickle = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool ketchup = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool mustard = true;

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");

                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
