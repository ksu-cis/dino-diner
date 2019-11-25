/*  MenuItem.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public abstract class MenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        ///<Summary>
        /// Ingredients in this entree.
        ///</Summary>
        public abstract List<string> Ingredients { get; }
    }
}
