/*  Triceritots.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets the pice and calories based on size of the side
        /// </summary>
        public override Size Size
        {
            set {
                size = value;
                switch(size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    default: break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list
        /// </summary>
        public Triceritots()
        {
            Size = Size.Small;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }

    }
}
