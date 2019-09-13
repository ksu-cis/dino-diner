/* TRexKingBurger.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the TRexKingBurger object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// This bool determines if the item contains tomato.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// This bool determines if the item contains onion.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// This bool determines if the item contains pickles.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// This bool determines if the item contains ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// This bool determines if the item contains mustard.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// This bool determines if the item contains mayonnaise.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// This double has a getter and a setter to decide the price of the menu item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This unsigned integer gives the calorie count for this menu item. It has a getter and 
        /// a setter.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all the ingredients of the burger and allows the bun, lettuce, tomato,
        /// onions, pickles, ketchup, mustard and mayo to be removed.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if (lettuce)
                {
                    ingredients.Add("Lettuce");
                }
                if (tomato)
                {
                    ingredients.Add("Tomato");
                }
                if (onion)
                {
                    ingredients.Add("Onion");
                }
                if (pickle)
                {
                    ingredients.Add("Pickle");
                }
                if (ketchup)
                {
                    ingredients.Add("Ketchup");
                }
                if (mustard)
                {
                    ingredients.Add("Mustard");
                }
                if(mayo)
                {
                    ingredients.Add("Mayo");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// This method allows the user to remove the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This method allows the user to remove the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// This method allows the user to remove the tomato.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// This method allows the user to remove the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// This method allows the user to remove the pickles.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// This method allows the user to remove the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// This method allows the user to remove the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// This method allows the user to remove the mayonnaise.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
