/*  Sodasuarus.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines properties for Sodasuarus
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// backing variable for flavor of soda
        /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// get set for soda flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets the pice and calories based on size of the drink
        /// </summary>
        public override Size Size {
            get
            {
                return size;
            }
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{size} {Flavor} Sodasaurus";
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
                return special.ToArray();
            }
        }
    }
}
