using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;




namespace DinoDiner.Menu
{
    
    public class CretaceousCombo
    {
        /// <summary>
        /// 
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Side Side { get; set; }

        private Size _size = Size.Small;
        public Size size
        {
            get { return _size; }
            set
            {
                _size = value;
                Drink.Size = Drink.Size;
                Side.Size = Side.Si;
            }
        }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price
        {
            get
            {
                return (Drink.Price + Entree.Price + Side.Price - 0.25);
            }
        }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return (Drink.Calories + Entree.Calories + Side.Calories);
            }
        }
        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        //public static CretaceousCombo GetCombo() { return new CretaceousCombo(); }
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"";
        }
    }
}
