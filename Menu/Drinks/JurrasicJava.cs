using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Creates a new instance of MeteorMacAndCheese as a small side
        /// </summary>
        public JurrasicJava()
        {
            size = Size.Small;
            Calories = 2;
            Price = 0.99;
            Ice = false;
        }
        /// <summary>
        /// leaves room for cream if true
        /// </summary>
        public bool _roomForCream = false;
        /// <summary>
        /// Makes the drink decaf
        /// </summary>
        public bool _decaf = false;
        /// <summary>
        /// Returns the ingredients that comprise the beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
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
                        Calories = 8;
                        Price = 1.49;
                        Ice = false;
                        break;
                    case Size.Medium:
                        Calories = 4;
                        Price = .99;
                        Ice = false;
                        break;
                    case Size.Small:
                        Calories = 2;
                        Price = 0.99;
                        Ice = false;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Makes room for cream
        /// </summary>
        public void RoomForCream() => _roomForCream = true;
        /// <summary>
        /// Makes the drink decalf
        /// </summary>
        public void MakeDecaf() => _decaf = true;
        /// <summary>
        /// Adds Ice
        /// </summary>
        public void AddIce() => Ice = true;
    }
}
