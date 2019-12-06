/*  CretaceousCombo.cs
*   Author: Creighton Glasscock
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Gets or sets the size of all items
        /// </summary>
        public Size Size
        {
            get
            {
                return Size;
            }

            set
            {
                Size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Gets or sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets or sets the side
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Gets or sets the drink
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Gets or sets the toy
        /// </summary>
        public string Toy { get; set; }

        /// <summary>
        /// Gets the price of all items, with discount
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price +Side.Price +Drink.Price -0.25;
            }
        }

        /// <summary>
        /// Gets the calories of all items
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories +Side.Calories +Drink.Calories;
            }
        }

        ///<Summary>
        /// Ingredients in all items.
        ///</Summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Makes combo with entree
        /// </summary>
        /// <param name="entree">The entree</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
            Toy = "Dino";
            Size = Size.Small;
        }

        /// <summary>
        /// String representation of name of this item
        /// </summary>
        /// <returns>Name of this item</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
    }
}