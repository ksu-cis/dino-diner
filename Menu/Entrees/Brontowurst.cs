using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the Brontowurst entree.
    /// </summary>
    public class Brontowurst
    {
        private bool _bun = true;
        private bool _peppers = true;
        private bool _onions = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients  
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Brautwurst" };
                if (_bun) Ingredients.Add("Whole Wheat Bun");
                if (_peppers) Ingredients.Add("Peppers");
                if (_onions) Ingredients.Add("Onion");
                return Ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Bun holding method.
        /// </summary>
        public void HoldBun()
        {
        _bun = false;
        }
        /// <summary>
        /// Removes the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            _peppers = false;
        }
        /// <summary>
        /// Removes the onions.
        /// </summary>
        public void HoldOnion()
        {
            _onions = false;
        }

    }
}
