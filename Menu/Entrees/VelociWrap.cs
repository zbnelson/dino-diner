/*  VelociWrap.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        /// <summary>
        /// creates boolean for if dressing is included
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// creates boolean for if lettuce is included
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// creates boolean for if cheese is included
        /// </summary>
        private bool cheese = true;

        ///<Summary>
        ///getter setter for the price
        ///</Summary>
        public double Price { get; set; }

        ///<Summary>
        ///getter setter for the calories
        ///</Summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast",  };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// sets dressing to false if it's not included
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// sets lettuce to false if it's not included
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// sets cheese to false if it's not included
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
