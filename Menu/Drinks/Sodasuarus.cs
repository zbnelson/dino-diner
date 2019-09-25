using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.SizeEnum;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasuarus : Drinks
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;
        
        /// <summary>
        /// 
        /// </summary>
        public override Size Size {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                    default: break;
                }
            }
        }
        public Sodasuarus()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
    }
}
