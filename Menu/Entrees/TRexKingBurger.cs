using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : SteakosaurusBurger
    {
        /// <summary>
        /// Variable to manage the occurance of mayo in a meal
        /// </summary>
        private bool _mayo = true;
        /// <summary>
        /// Generates a list of the ingredients in a TRexKingBurger meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                    { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (getBun) ingredients.Add("Whole Wheat Bun");
                if (getPickle) ingredients.Add("Pickle");
                if (getKetchup) ingredients.Add("Ketchup");
                if (getMustard) ingredients.Add("Mustard");
                if (getLettuce) ingredients.Add("Lettuce");
                if (getTomato) ingredients.Add("Tomato");
                if (getOnion) ingredients.Add("Onion");
                if (_mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of a TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }
        /// <summary>
        /// Method used to remove mayo from the meal
        /// </summary>
        public void HoldMayo()
        {
            _mayo = false;
        }
    }
}
