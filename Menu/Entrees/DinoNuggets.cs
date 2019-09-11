using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int nuggets;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.nuggets = 6;
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        public void AddNugget()
        {
            this.nuggets += 1;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
