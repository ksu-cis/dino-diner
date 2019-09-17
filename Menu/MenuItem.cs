using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public abstract class MenuItem
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public abstract List<string> Ingredients { get; }
    }
}
