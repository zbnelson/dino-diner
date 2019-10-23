/*  Triceritots.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                switch (size)
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

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the name
        /// </summary>
        /// <returns>Side name</returns>
        public override string ToString()
        {
            return $"{size} Triceritots";
        }

    }
}
