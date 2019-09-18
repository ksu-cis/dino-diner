using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 322;
        }

        public override List<string> Ingredients { get { return new List<string>() { "Potato", "Salt", "Vegetable Oil" }; } }
        protected Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        break;
                    case Size.Medium:
                        this.Price = 1.95;
                        break;
                    case Size.Small:
                        this.Price = 1.95;
                        break;
                }
            }
            get { return size; }
        }
    }
}
