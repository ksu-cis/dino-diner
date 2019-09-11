using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        public TRexKingBurger()
        {
            ingredients = new List<string>() { "Whole Wheat Bun", "Three Steakburger Patties", "Lettuce", "Tomato", "Onion", "Pickle", "Ketchup", "Mustard", "Mayo" };
            price = 8.45;
            calories = 728;
            count = 1;
        }
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }
    }
}
