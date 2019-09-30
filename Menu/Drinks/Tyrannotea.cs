using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Create a new tyrannotea instance with default options.
        /// </summary>
        public Tyrannotea()
        {
            ingredients = new List<string>() { "Water", "Tea" };
            prices = new double[] { .99, 1.49, 1.99 };
            calories = new uint[] { 8, 16, 32 };
        }

        bool lemon = false;

        /// <summary>
        /// Returns whether or not lemon should be added in the tea
        /// </summary>
        public bool Lemon { get { return lemon; } }

        bool sweet = false;

        /// <summary>
        /// Makes the tea sweet and adds sugar to the ingredients.
        /// </summary>
        public bool Sweet
        {
            get{return Sweet; }
            set
            {
                sweet = value;
                ingredients.Add("Cane Sugar");
            }
        }

        /// <summary>
        /// Returns the calories depending upon if the tea is sweat or not
        /// </summary>
        public override uint Calories
        {
            get { return (calories[(int)Size]) * (Sweet ? (uint)2 : (uint)1); }
        }

        /// <summary>
        /// Adds Lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
        }
    }
}
