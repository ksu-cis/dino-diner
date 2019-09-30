using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.AbstractClasses
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public abstract class Drink
    {
        protected double[] prices = new double[3];


        /// <summary>
        /// The amount of calories in each size
        /// </summary>
        protected uint[] calories;

        /// <summary>
        /// The total calories within the item. This is not representative of the calories 
        /// after removing ingrients.
        /// </summary>
        public virtual uint Calories
        {
            get { return ( calories[ ( int )Size ] ); }
        }

        protected bool ice = true;

        public bool Ice { get { return ice; } }

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
        public Size Size = Size.Small;

        /// <summary>
        /// Removes Ice from the drink 
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }

    }
}
