using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks()
        {
            calories = new List<uint>() { 540, 610, 720 };
            ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };

        }
    }
}
