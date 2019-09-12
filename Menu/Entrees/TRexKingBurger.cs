/*  Brontowurst.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool bun = true;
        ///<Summary>
        /// Number of this ingredient in this entree.
        ///</Summary>
        private int pattyCount = 3;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool lettuce = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool tomato = true;
        ///<Summary>
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool onion = true;
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
        /// Whether this ingredient is in this entree.
        ///</Summary>
        private bool mayo = true;

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
                List<string> ingredients = new List<string>() { };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");

                for(int i = 0; i < pattyCount; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }

                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldOnion()
        {
            this.onion = false;
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

        ///<Summary>
        /// Removes this ingredient from this entree.
        ///</Summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
