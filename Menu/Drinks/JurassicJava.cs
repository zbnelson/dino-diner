/* JurrasicJava.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines properties for JurrasicJava
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Sets the pice and calories based on size of the drink
        /// </summary>
        public override Size Size
        {
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
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
        /// sets room for coffee to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Makes the drink decaf
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list and sets ice to false by default;
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Coffee");

        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the size and name
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            if (!Decaf)
                return $"{size} Jurassic Java";
            else
                return $"{size} Decaf Jurassic Java";
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice)
                {
                    special.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    special.Add("Leave Room for Cream");
                }
                return special.ToArray();
            }
        }
    }
}
