/*  PterodactylWings.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {

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
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };

                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
