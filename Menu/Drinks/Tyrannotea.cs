using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Holds the size of the side
        /// </summary>
        private Size size;

        public bool Lemon { get; set; } = false;
        public bool Sweet { get; set; } = false;

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

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

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

        public Tyrannotea()
        {
            Size = Size.Small;
            ingredients.Add("Water");
            Ingredients.Add("Tea");
        }
    }
}