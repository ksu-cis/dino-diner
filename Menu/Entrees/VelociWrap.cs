using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the VelociWrap.
    /// </summary>
    public class VelociWrap
    {
        private bool _dressing = true;
        private bool _lettuce = true;
        private bool _cheese = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (_dressing) Ingredients.Add("Ceasar Dressing");
                if (_lettuce) Ingredients.Add("Romaine Lettuce");
                if (_cheese) Ingredients.Add("Parmesan Cheese");
                return Ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Dressing holding method.
        /// </summary>
        public void HoldDressing()
        {
            _dressing = false;
        }

        /// <summary>
        /// Lettuce holding method.
        /// </summary>
        public void HoldLettuce()
        {
            _lettuce = false;
        }

        /// <summary>
        /// Cheese holding method.
        /// </summary>
        public void HoldCheese()
        {
            _cheese = false;
        }
    }
}
