using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Enum of possible soda flavors
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    };

    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor flavor;
        /// <summary>
        /// Creates a new Sodasaurus instance
        /// </summary>
        public Sodasaurus()
        {
            ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            prices = new double[] { 1.5, 2, 2.5 };
            calories = new uint[] { 112, 156, 208 };
        }
    }
}
