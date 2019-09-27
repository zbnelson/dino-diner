/* JurrasicJava.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines properties for JurrasicJava
    /// </summary>
    public class JurrasicJava : Drink
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
            get { return size; }
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
            }
        }

        /// <summary>
        /// sets room for coffee to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Makes the drink decaf
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
        }

        /// <summary>
        /// adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// uses the size to find price and calories, then adds the ingredients to the ingredients list and sets ice to false by default;
        /// </summary>
        public JurrasicJava()
        {
            Ice = false;
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Coffee");

        }
    }
}
