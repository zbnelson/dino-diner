using DinoDiner.Menu.SizeEnum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Drinks
    {
        private SodasuarusFlavor flavor;
        public SodasuarusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get { return ingredients; }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public Boolean Ice { get; set; } = true;

        public void HoldIce()
        {
            Ice = false;
        }
    }
}
