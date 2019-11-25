/*  DinoNuggets.cs
*   Author: Creighton Glasscock
*/

using System.Collections.Generic;

namespace Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        ///<Summary>
        /// Number of this ingredient in this entree.
        ///</Summary>
        private int nuggetCount = 6;

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public override List<string> Ingredients
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
