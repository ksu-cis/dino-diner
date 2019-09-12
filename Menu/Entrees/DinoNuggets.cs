/*  Brontowurst.cs
*   Author: Creighton Glasscock
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        ///<Summary>
        /// Number of this ingredient in this entree.
        ///</Summary>
        private int nuggetCount = 6;

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
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        ///<Summary>
        /// Initializes this entree.
        ///</Summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * (uint)nuggetCount;
        }

        ///<Summary>
        /// Adds an extra nugget to this entree.
        ///</Summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }
    }
}
