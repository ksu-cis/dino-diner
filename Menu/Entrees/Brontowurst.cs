using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Private variables used to determine the ingredients to add into the meal
        /// </summary>
        private bool _bun = true;
        private bool _peppers = true;
        private bool _onions = true;
        /// <summary>
        /// Generates a list of the ingredients in a Brontowurst meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (_bun) ingredients.Add("Whole Wheat Bun");
                if (_peppers) ingredients.Add("Peppers");
                if (_onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of Brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Method used to remove bun in the meal
        /// </summary>
        public void HoldBun()
        {
            _bun = false;
        }
        /// <summary>
        /// Method used to remove peppers in the meal
        /// </summary>
        public void HoldPeppers()
        {
            _peppers = false;
        }
        /// <summary>
        /// Method used to remove onion from the meal
        /// </summary>
        public void HoldOnion()
        {
            _onions = false;
        }

    }
}
