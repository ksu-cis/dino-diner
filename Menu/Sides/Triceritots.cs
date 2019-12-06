/*  Triceritots.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return SizeExtension.SizeString(Size) + " Triceritots";
        }

        /// <summary>
        /// Prices for each size
        /// </summary>
        public override double[] SizePrices
        {
            get
            {
                return new double[] { .99, 1.45, 1.95 };
            }
        }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public override uint[] SizeCalories
        {
            get
            {
                return new uint[] { 352, 410, 590 };
            }
        }

        ///<Summary>
        /// Ingredients in this item.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() {
                    "Potatoes", "Salt", "Vegetable Oil"
                };
            }
        }
    }
}