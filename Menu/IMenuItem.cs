/*  IMenuItem.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get; }

        ///<Summary>
        /// Ingredients in this item.
        ///</Summary>
        List<string> Ingredients { get; }
    }
}
