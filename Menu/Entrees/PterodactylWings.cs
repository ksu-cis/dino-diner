using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class PterodactylWings
    {
        public double price { get; set; }
        public uint calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken", "Wings Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.price = 7.21;
            this.calories = 318;
        }
    }
}
