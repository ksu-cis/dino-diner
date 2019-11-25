using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Sides
{

    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side
    {
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }

        public override double Price {
            get
            {
                switch (Size)
                {
                    case Small: return sizePrices[0]; break;
                }
            }
            

        }

        public double[] sizePrices = { 0.0, 0.0, 0.0 };
        public double[] sizeCalories = { 0.0, 0.0, 0.0 };
    }
}
