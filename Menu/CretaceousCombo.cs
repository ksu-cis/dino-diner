using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.AbstractClasses;
using System.Linq;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public CretaceousCombo( Entree entree )
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        public Entree Entree { get; set; }
        Side side;
        public Side Side
        {
            get { return side; }
            set {
                this.side = value;
                this.side.Size = this.size;
            }
        }
        public Drink Drink { get; set;  }

        public double Price
        {
            get
            {
                return (Entree.Price + Side.Price + Drink.Price) - .25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        public Sides.Size size = Sides.Size.Small;
        public Sides.Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = (AbstractClasses.Size)value;
                Side.Size = value;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }
    }
}
