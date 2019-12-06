/*  Tyrannotea.cs
*   Author: Creighton Glasscock
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return SizeExtension.SizeString(Size) + (Sweet ? " Sweet" : "") + " Tyrannotea";
        }

        /// <summary>
        /// Sweetness
        /// </summary>
        public bool Sweet { get; set; }

        /// <summary>
        /// Denotes presence of lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Prices for each size
        /// </summary>
        public override double[] SizePrices
        {
            get
            {
                return new double[] { .99, 1.49, 1.99 };
            }
        }

        /// <summary>
        /// Calories for each size
        /// </summary>
        public override uint[] SizeCalories
        {
            get
            {
                return Sweet ? new uint[] { 16, 32, 64 }
                             : new uint[] { 8, 16, 32 };
            }
        }

        /// <summary>
        /// Makes this item sweet
        /// </summary>
        public void AddSweetener()
        {
            Sweet = true;
        }


        /// <summary>
        /// Makes this item lemony
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        ///<Summary>
        /// Ingredients in this item.
        ///</Summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients =  new List<string>() { 
                    "Water", "Tea"
                };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
    }
}
