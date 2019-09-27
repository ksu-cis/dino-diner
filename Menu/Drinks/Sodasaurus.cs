using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Enum for the different flavours avaliable in the Soda drink.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola, Orange, Vanilla, Chocolate, RootBeer, Cherry, Lime
    }
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients { get { return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" }; } }
        /// <summary>
        /// Gets and Set the natural flavour of the drink
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; } = SodasaurusFlavor.Cola;
        protected Size _size = Size.Small;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                Size = value;
                switch (Size)
                {
                    case Size.Large:
                        Calories = 208;
                        Price = 2.50;
                        break;
                    case Size.Medium:
                        Calories = 156;
                        Price = 2.00;
                        break;
                    case Size.Small:
                        Calories = 112;
                        Price = 1.50;
                        break;
                }
            }
            get { return Size; }
        }
    }
}
