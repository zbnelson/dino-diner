using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// 
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

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void MakeDecaf()
        {
            Decaf = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        public JurrasicJava()
        {
            Ice = false;
            Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Coffee");

        }
    }
}
