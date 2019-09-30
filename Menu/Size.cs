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
    public class ItemSize
    {
        /// <summary>
        /// Sets the size of the item
        /// </summary>
        public Size size { get; set; }
    }
}
