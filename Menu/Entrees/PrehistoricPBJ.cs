﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
