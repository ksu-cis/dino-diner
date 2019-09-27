using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {

        /// <summary>
        /// 
        /// </summary>
        private bool _roomForCream = false;
        /// <summary>
        /// 
        /// </summary>
        private bool _decaf = false;
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
        protected Size _size = Size.Small;
        /// <summary>
        /// Sets the size of the selected side and updates the Calories and Price accordingly
        /// </summary>
        public override Size Size
        {
            set
            {
                Size = value;
                switch (Size)
                {
                    case Size.Large:
                        Calories = 32;
                        Price = 1.99;
                        Ice = false;
                        break;
                    case Size.Medium:
                        Calories = 16;
                        Price = 1.49;
                        Ice = false;
                        break;
                    case Size.Small:
                        Calories = 8;
                        Price = 0.99;
                        Ice = false;
                        break;
                }
            }
            get { return Size; }
        }
        /// <summary>
        /// 
        /// </summary>
        public void RoomForCream() => _roomForCream = false;
        /// <summary>
        /// 
        /// </summary>
        public void MakeDecaf() => _decaf = false;
        /// <summary>
        /// 
        /// </summary>
        public void AddIce() => Ice = true;
    }
}
