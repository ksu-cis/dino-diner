/*  Sodasaurus.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        /// Converts SodasaurusFlavor enum to string
        /// </summary>
        /// <returns>SodasaurusFlavor enum</returns>
        public static string FlavorString(SodasaurusFlavor f)
        {
            switch (f)
            {
                case SodasaurusFlavor.Cola: return "Cola";
                case SodasaurusFlavor.Orange: return "Orange";
                case SodasaurusFlavor.Vanilla: return "Vanilla";
                case SodasaurusFlavor.Chocolate: return "Chocolate";
                case SodasaurusFlavor.RootBeer: return "RootBeer";
                case SodasaurusFlavor.Cherry: return "Cherry";
                case SodasaurusFlavor.Lime: return "Lime";
                default: return "Unknown Flavor";
            }
        }

        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return SizeExtension.SizeString(Size) + " " +  FlavorString(Flavor) + " Sodasaurus";
        }


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
