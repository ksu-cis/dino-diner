﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        public SteakosaurusBurger()
        {
            ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Pickle", "Ketchup", "Mustard" };
            price = 5.15;
            calories = 621;
            count = 1;
        }
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
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
    }
}