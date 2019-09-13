/*  SteakosaurusBurger.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        /// <summary>
        /// creates boolean for if bun is included
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// creates boolean for if pickle is included
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// creates boolean for if ketchup is included
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// creates boolean for if mustard is included
        /// </summary>
        private bool mustard = true;

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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// sets bun to false if it's not included
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// sets pickle to false if it's not included
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// sets ketchup to false if it's not included
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// sets mustard to false if it's not included
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
