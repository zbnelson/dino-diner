/*  Sides.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using DinoDiner.Menu;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// class that gets/sets the price, calories and ingredients list for sides.
    /// </summary>
    public abstract class Side
    {
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
        public List<string> Ingredients {
            get {return ingredients;}
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
