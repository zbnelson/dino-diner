/*  Water.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines properties for Water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Sets the size of the drink
        /// </summary>
        public override Size Size
        {
            get
            {
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// finds size, sets price and calories, and adds the ingredients to the ingredients list
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Price = .1;
            Calories = 0;
            ingredients.Add("Water");
           
        }

        /// <summary>
        /// adds Lemon to the drink and ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{size} Water";
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                if (Lemon)
                {
                    special.Add("Add Lemon");
                }
                return special.ToArray();
            }
        }
    }
}
