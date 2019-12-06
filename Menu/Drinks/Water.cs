/*  Water.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return SizeExtension.SizeString(Size) + " Water";
        }

        /// <summary>
        /// Denotes presence of lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Prices for each size
        /// </summary>
        public override double[] SizePrices
        {
            get
            {
                return new double[] { .10, .10, .10 };
            }
        }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public override uint[] SizeCalories
        {
            get
            {
                return new uint[] { 0, 0, 0 };
            }
        }

        /// <summary>
        /// Makes this item lemony
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        ///<Summary>
        /// Ingredients in this item.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {
                    "Water"
                };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
    }
}
