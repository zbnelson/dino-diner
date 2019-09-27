using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;
        public Water()
        {
            Size = Size.Small;
            Price = .1;
            Calories = 0;
            ingredients.Add("Water");
           
        }
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
