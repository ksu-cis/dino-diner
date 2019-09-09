using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {
        public Brontowurst()
        {
            ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Peppers", "Onion" };
            price = 5.36;
            calories = 498;
            count = 1;
        }
        
        public void HoldBun()
        {
            ingredients.Remove( "Whole Wheat Bun" );
        }
        public void HoldPeppers()
        {
            ingredients.Remove( "Peppers" );
        }
        public void HoldOnion()
        {
            ingredients.Remove( "Onion" );
        }
    }
}
