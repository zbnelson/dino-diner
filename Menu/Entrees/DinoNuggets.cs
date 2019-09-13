/*  TRexKingBurger.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        ///<Summary>
        ///int counter for number of nuggets ordered
        ///</Summary>
        public int nuggetCount = 6;

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
                List<string> ingredients = new List<string>() {  };
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        /// <summary>
        /// adds chicken nugget to ingredients and changes the price and calories to correct.
        /// </summary>
        public void AddNugget()
        {
            this.Price = Price + .25;
            this.Calories = Calories + 59;
            nuggetCount = nuggetCount + 1;
        }

    }
}
