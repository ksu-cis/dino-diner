/*  MeteorMacAndCheese.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return SizeExtension.SizeString(Size) + " Meteor Mac and Cheese";
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
                return new uint[] { 420, 490, 520 };
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
                    "Macaroni Noodles", "Cheese Product", "Pork Sausage"
                };
            }
        }
    }
}