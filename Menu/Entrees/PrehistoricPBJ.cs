using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Variable to manage the occurance of peanut butter in a meal
        /// </summary>
        private bool _peanutButter = true;
        /// <summary>
        /// Variable to manage the occurance of jelly in a meal
        /// </summary>
        private bool _jelly = true;
        /// <summary>
        /// Generates a list of the ingredients in a PrehistoricPBJ meal
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (_peanutButter) ingredients.Add("Peanut Butter");
                if (_jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor used to create a default instance of PrehistoricPBJ 
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Method used to remove peanut butter from the meal
        /// </summary>
        public void HoldPeanutButter()
        {
            _peanutButter = false;
        }
        /// <summary>
        /// Method used to remove jelly from the meal
        /// </summary>
        public void HoldJelly()
        {
            _jelly = false;
        }
    }
}
