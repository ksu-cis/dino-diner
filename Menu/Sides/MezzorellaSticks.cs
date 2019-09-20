using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Creates a new instance of MezzorellaSticks as a small side
        /// </summary>
        public MezzorellaSticks()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// Generates a list of the ingredients in a MezzorellaSticks
        /// </summary>
        public override List<string> Ingredients { get { return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" }; } }
        protected Size size;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Calories = 720;
                        Price = 1.95;
                        break;
                    case Size.Medium:
                        Calories = 610;
                        Price = 1.45;
                        break;
                    case Size.Small:
                        Calories = 540;
                        Price = 0.99;
                        break;
                }
            }
            get { return size; }
        }
    }
}
