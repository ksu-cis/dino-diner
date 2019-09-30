using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{

    public class Water : Drink
    {

        public bool _lemon = false;
        /// <summary>
        /// Controls the size of he drink in this instance of tea
        /// </summary>
        protected Size _size = Size.Small;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                _size = value;
                switch (_size)
                {
                    case Size.Large:
                        Calories = 0;
                        Price = 0.10;
                        break;
                    case Size.Medium:
                        Calories = 0;
                        Price = .10;
                        break;
                    case Size.Small:
                        Calories = 0;
                        Price = 0.10;
                        break;
                }
            }
            get { return _size; }
        }
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return (_lemon == false) ? new List<string>{"Water"} : new List<string> { "Water", "Lemon"};
            }
        }
        /// <summary>
        /// Method to add lemon to the drink
        /// </summary>
        public void AddLemon() => _lemon = true;
    }
}
