using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Creates a new water instance
        /// </summary>
        public Water()
        {
            ingredients = new List<string>() { "Water" };
            prices = new double[] { .1, .1, .1 };
            
            calories = new uint[] { 0, 0, 0 };
        }
        bool lemon = false;
        /// <summary>
        /// Returns whether Lemon should be added into the drink
        /// </summary>
        public bool Lemon { get { return lemon; } }
        /// <summary>
        /// Adds lemon into the drink 
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
