﻿/*  Side.cs
*   Author: Creighton Glasscock
*/
namespace DinoDiner.Menu.Sides
{
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side : MenuItem
    {
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }


        /// <summary>
        /// Prices for each size
        /// </summary>
        public abstract double[] SizePrices { get; }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public abstract uint[] SizeCalories { get; }

        /// <summary>
        /// Gets the price
        /// </summary>
        public override double Price {
            get
            {
                switch (Size)
                {
                    case Size.Small: return SizePrices[0];
                    case Size.Medium: return SizePrices[1];
                    case Size.Large: return SizePrices[2];
                    default: return SizePrices[0];
                }
            }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return SizeCalories[0];
                    case Size.Medium: return SizeCalories[1];
                    case Size.Large: return SizeCalories[2];
                    default: return SizeCalories[0];
                }
            }
        }
    }
}
