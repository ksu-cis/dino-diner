using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the Burger.
    /// </summary>
    public class SteakosaurusBurger
    {
        private bool _bun = true;
        private bool _pickle = true;
        private bool _ketchup = true;
        private bool _mustard = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() {"Steakburger Pattie"};
                if (_bun) Ingredients.Add("Whole Wheat Bun");
                if (_pickle) Ingredients.Add("Pickle");
                if (_ketchup) Ingredients.Add("Ketchup");
                if (_mustard) Ingredients.Add("Mustard");
                return Ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Bun holding method.
        /// </summary>
        public void HoldBun()
        {
            _bun = false;
        }

        /// <summary>
        /// Pickles holding method.
        /// </summary>
        public void HoldPickle()
        {
            _pickle = false;
        }

        /// <summary>
        /// Ketchup holding method.
        /// </summary>
        public void HoldKetchup()
        {
            _ketchup = false;
        }

        /// <summary>
        /// Mustard holding method.
        /// </summary>
        public void HoldMustard()
        {
            _mustard = false;
        }
    }
}
