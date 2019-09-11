using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint chickenNugget;
        public uint ChickenNugget { get { return chickenNugget; } private set { chickenNugget = value; } }
        public double Price { get { return 4.25 + ((ChickenNugget - 6) * .25); } }
        public uint Calories { get { return 59 * ChickenNugget; } }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < ChickenNugget; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }

                return ingredients;
            }
        }


        public DinoNuggets()
        {
            chickenNugget = 6;
        }

        public void AddNugget()
        {
            ChickenNugget++;
        }
    }
}
