using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        SteakosaurusBurger sb = new SteakosaurusBurger();
        private bool mayo = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                    { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (sb.getBun) ingredients.Add("Whole Wheat Bun");
                if (sb.getPickle) ingredients.Add("Pickle");
                if (sb.getKetchup) ingredients.Add("Ketchup");
                if (sb.getMustard) ingredients.Add("Mustard");
                if (sb.getLettuce) ingredients.Add("Lettuce");
                if (sb.getTomato) ingredients.Add("Tomato");
                if (sb.getOnion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }        
        public void HoldMayo()
        {
            mayo = false;
        }


    }
}
