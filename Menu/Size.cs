using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public abstract class ItemSize
    {
        /// <summary>
        /// Sets the size of the item
        /// </summary>
        public abstract Size size { get; set; }
    }
}
