﻿/*  Brontowurst.cs
*   Author: Creighton Glasscock
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool bun = true;

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool peppers = true;

        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool onion = true;

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
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
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
