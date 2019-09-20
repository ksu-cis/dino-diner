using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            calories = new List<uint>() { 222, 365, 480 };
            ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
