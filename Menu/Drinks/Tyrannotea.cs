using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public Tyrannotea()
        {
            size = Size.Small;
            Calories = 8;
            Price = 0.99;
        }
        /// <summary>
        /// Controls if there is lemon in the drink
        /// </summary>
        public bool lemon = false;
        /// <summary>
        /// Controls if there are any added sweeteners
        /// </summary>
        public bool sweetened = false;
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (lemon == true)
                    ingredients.Add("Lemon");
                if (sweetened == true)
                    ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Controls the size of he drink in this instance of tea
        /// </summary>
        protected Size size;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Calories = 32;
                        Price = 1.99;
                        break;
                    case Size.Medium:
                        Calories = 16;
                        Price = 1.49;
                        break;
                    case Size.Small:
                        Calories = 8;
                        Price = 0.99;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add lemon to the drink
        /// </summary>
        public void AddLemon() => lemon = true;
        /// <summary>
        /// Method to add sugar to the drink
        /// </summary>
        public void AddSugar()
        {
            sweetened = true;
            switch (size)
            {
                case Size.Large:
                    Calories = 64;
                    break;
                case Size.Medium:
                    Calories = 32;
                    break;
                case Size.Small:
                    Calories = 16;
                    break;
            }
        }
    }
}
