/*  Menu.cs
*   Author: Creighton Glasscock
*/

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; private set; }

        /// <summary>
        /// Available entrees
        /// </summary>
        public List<Entree> AvailableEntrees { get; private set; }

        /// <summary>
        /// Available sides
        /// </summary>
        public List<Side> AvailableSides { get; private set; }

        /// <summary>
        /// Available drinks
        /// </summary>
        public List<Drink> AvailableDrinks { get; private set; }

        /// <summary>
        /// Available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos { get; private set; }

        /// <summary>
        /// Adds item to menu lists
        /// </summary>
        /// <param name="item">Menu item</param>
        public void Add(IMenuItem item)
        {
            AvailableMenuItems.Add(item);

            if (item is Entree) AvailableEntrees.Add(item as Entree);
            if (item is Side) AvailableSides.Add(item as Side);
            if (item is Drink) AvailableDrinks.Add(item as Drink);
            if (item is CretaceousCombo) AvailableCombos.Add(item as CretaceousCombo);
        }

        /// <summary>
        /// Removes item from menu lists
        /// </summary>
        /// <param name="item">Menu item</param>
        public void Remove(IMenuItem item)
        {
            AvailableMenuItems.Remove(item);

            if (item is Entree) AvailableEntrees.Remove(item as Entree);
            if (item is Side) AvailableSides.Remove(item as Side);
            if (item is Drink) AvailableDrinks.Remove(item as Drink);
            if (item is CretaceousCombo) AvailableCombos.Remove(item as CretaceousCombo);
        }

        /// <summary>
        /// Makes a menu including all menu items
        /// </summary>
        public Menu()
        {
            AvailableMenuItems = new List<IMenuItem>();

            AvailableEntrees = new List<Entree>();
            Add(new Brontowurst());
            Add(new DinoNuggets());
            Add(new PrehistoricPBJ());
            Add(new PterodactylWings());
            Add(new SteakosaurusBurger());
            Add(new TRexKingBurger());
            Add(new VelociWrap());

            AvailableSides = new List<Side>();
            Add(new Fryceritops());
            Add(new MeteorMacAndCheese());
            Add(new MezzorellaSticks());
            Add(new Triceritots());

            AvailableDrinks = new List<Drink>();
            Add(new JurassicJava());
            Add(new Sodasaurus());
            Add(new Tyrannotea());
            Add(new Water());

            AvailableCombos = new List<CretaceousCombo>();
        }

        /// <summary>
        /// A list of all available menu items, one item per line.
        /// </summary>
        /// <returns>A list of all available menu items, one item per line.</returns>
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < AvailableMenuItems.Count; i++)
            {
                s += AvailableMenuItems[i];
                if (i != AvailableMenuItems.Count - 1) s += "\n";
            }

            return s;
        }
    }
}
