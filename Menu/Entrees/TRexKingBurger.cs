using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Manages the King burger.
    /// </summary>
    public class TRexKingBurger
    {
        private bool _ketchup = true;
        private bool _lettuce = true;
        private bool _mustard = true;
        private bool _bun = true;
        private bool _tomato = true;
        private bool _pickle = true;
        private bool _onion = true;
        private bool _mayo = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (_lettuce) Ingredients.Add("Lettuce");
                if (_mustard) Ingredients.Add("Mustard");
                if (_ketchup) Ingredients.Add("Ketchup"); 
                if (_bun) Ingredients.Add("Whole Wheat Bun");
                if (_tomato) Ingredients.Add("Tomato");
                if (_pickle) Ingredients.Add("Pickle");
                if (_onion) Ingredients.Add("Onion");
                if (_mayo) Ingredients.Add("Mayo");
                return Ingredients;
            }
        }

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Holds the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            _ketchup = false;
        }
        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            _lettuce = false;
        }
        /// <summary>
        /// Holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            _mayo = false;
        }
        /// <summary>
        /// Holds the mustard.
        /// </summary>
        public void HoldMustard()
        {
            _mustard = false;
        }
        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            _bun = false;
        }
        /// <summary>
        /// Holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            _onion = false;
        }
        /// <summary>
        /// Holds the pickle.
        /// </summary>
        public void HoldPickle()
        {
            _pickle = false;
        }
        /// <summary>
        /// Holds the tomato.
        /// </summary>
        public void HoldTomato()
        {
            _tomato = false;
        }
    }
}
