using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
        }
        /// <summary>`
        /// Generates a list of the ingredients in a MMC
        /// </summary>
        public override List<string> Ingredients { get { return new List<string>() { "Potato", "Salt", "Vegetable Oil" }; } }
        protected Size _size;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                _size = value;
                switch (_size)
                {
                    case Size.Large:
                        Calories = 480;
                        Price = 1.95;
                        break;
                    case Size.Medium:
                        Calories = 365;
                        Price = 1.45;
                        break;
                    case Size.Small:
                        Calories = 222;
                        Price = 0.99;
                        break;
                }
            }
            get { return _size; }
        }
    }
}
