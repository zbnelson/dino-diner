/*  tyrannotea.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines properties for TyrannoTea
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        public bool Lemon { get; set; } = false;
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Sets the pice and calories based on size of the drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// adds Lemon to the drink and ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// Uses sweet to determine if it needs to add sweetener or remove sweetener. Changes calories and ingredients based on that.
        /// </summary>
        public void AddSweetener()
        {
            if (Sweet == false)
            {
                Sweet = true;
                Calories *= 2;
                ingredients.Add("Cane Sugar");
            }
            else
            {
                Sweet = false;
                Calories /= 2;
                ingredients.Remove("Cane Sugar");
            }

        }

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            Ingredients.Add("Tea");
        }
    }
}