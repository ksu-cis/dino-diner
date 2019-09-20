using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
            calories = new List<uint>() { 352, 410, 590 };
            ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
