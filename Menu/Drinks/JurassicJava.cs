/*  JurassicJava.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Denotes the presence of ice
        /// </summary>
        public override bool Ice { get; set; }

        /// <summary>
        /// Denotes cream room
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Denotes decaffination
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Prices for each size
        /// </summary>
        public override double[] SizePrices
        {
            get
            {
                return new double[] { .59, .99, 1.49 };
            }
        }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public override uint[] SizeCalories
        {
            get
            {
                return new uint[] { 2, 4, 8 };
            }
        }

        /// <summary>
        /// Adds ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        ///<Summary>
        /// Ingredients in this item.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() {
                    "Water", "Coffee"
                };
            }
        }
    }
}
