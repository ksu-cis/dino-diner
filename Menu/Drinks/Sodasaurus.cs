/*  Sodasaurus.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola, 
        Orange, 
        Vanilla, 
        Chocolate, 
        RootBeer, 
        Cherry, 
        Lime
    }
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Flavor of item
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Prices for each size
        /// </summary>
        public override double[] SizePrices
        {
            get
            {
                return new double[] { 1.50, 2.00, 2.50 };
            }
        }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public override uint[] SizeCalories
        {
            get
            {
                return new uint[] { 112, 156, 208 };
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
                    "Water", "Natural Flavors", "Cane Sugar"
                };
            }
        }
    }
}
