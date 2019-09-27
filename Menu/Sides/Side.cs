using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    

    public abstract class Side : ItemSize
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        //public abstract List<string> Ingredients { get; protected set; }
        public abstract Size Size { get; set; }

    }
}
