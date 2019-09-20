using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Variable to manage the occurances of ingredients in a meal
        /// </summary>
        private bool _dressing = true;
        private bool _lettuce = true;
        private bool _cheese = true;
        /// <summary>
        /// Generates a list of the ingredients in a VelociWrap meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {"Flour Tortilla", "Chicken Breast" };
                if (_dressing) ingredients.Add("Ceasar Dressing");
                if (_lettuce) ingredients.Add("Romaine Lettuce");
                if (_cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of a VelociWrap
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// Method used to remove dressing from the meal
        /// </summary>
        public void HoldDressing()
        {
            _dressing = false;
        }
        /// <summary>
        /// Method used to remove lettuce from the meal
        /// </summary>
        public void HoldLettuce()
        {
            _lettuce = false;
        }
        /// <summary>
        /// Method used to remove cheese from the meal
        /// </summary>
        public void HoldCheese()
        {
            _cheese = false;
        }
    }
}
