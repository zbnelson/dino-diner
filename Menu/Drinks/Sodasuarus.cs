/*  Sodasuarus.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines properties for Sodasuarus
    /// </summary>
    public class Sodasuarus : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets the pice and calories based on size of the drink
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

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list
        /// </summary>
        public Sodasuarus()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
    }
}
