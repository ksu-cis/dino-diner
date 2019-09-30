﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Removes or adds ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public abstract List<string> Ingredients { get; }
        
        /// <summary>
        /// Removes Ice from the drink
        /// </summary>
        public void HoldIce() { Ice = false; }

        public abstract Size Size { get; set; }
    }
}
