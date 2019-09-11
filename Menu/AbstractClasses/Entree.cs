using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.AbstractClasses
{
    public abstract class Entree
    {
        protected double add_price = 0.00;

        protected double price;

        public double Price
        {
            get { return price + count * add_price; }
        }
        protected uint count;

        protected uint base_count;

        protected uint calories;

        public uint Calories
        {
            get { return (calories * count); }
        }

        protected List<string> ingredients;

        public List<string> Ingredients
        {
            get { return new List<string>(ingredients); }
        }

    }
}
