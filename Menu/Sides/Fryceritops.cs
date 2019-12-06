﻿/*  Fryceritops.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {


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
                return new uint[] { 222, 365, 480 };
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