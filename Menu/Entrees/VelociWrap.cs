using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {

        private bool _dressing = true;
        private bool _lettuce = true;
        private bool _cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }


        public List<string> Ingredients
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

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            _dressing = false;
        }
        public void HoldLettuce()
        {
            _lettuce = false;
        }
        public void HoldCheese()
        {
            _cheese = false;
        }
    }
}
