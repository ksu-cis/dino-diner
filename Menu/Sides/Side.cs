using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    public enum Size
    {
        Small,
        Medium, 
        Large
    }


    public abstract class Side
    {
        readonly double[] prices =
        {
            .99,
            1.45,
            1.95
        };


        /// <summary>
        /// The price of the current entree. Includes the additional items.
        /// </summary>
        public double Price
        {
            get { return prices[ (int)Size ]; }
        }

        /// <summary>
        /// Current count of the items. This should be the updated count.
        /// </summary>
        public Size Size;

        
        /// <summary>
        /// The amount of calories in one. For example, with nuggets, it should be the 
        /// calories for one nugget.
        /// </summary>
        protected List<uint> calories;

        /// <summary>
        /// The total calories within the item. This is not representative of the calories 
        /// after removing ingrients. It is updated to show additional items.
        /// </summary>
        public uint Calories
        {
            get { return (calories[ (int)Size ] ); }
        }

        /// <summary>
        /// List of ingriendents.
        /// </summary>
        protected List<string> ingredients;

        /// <summary>
        /// Returns a copy of the ingredients list.
        /// </summary>
        public List<string> Ingredients
        {
            get { return new List<string>(ingredients); }
        }

    }
}
