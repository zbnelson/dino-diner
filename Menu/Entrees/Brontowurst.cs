/*  Brontowurst.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        /// <summary>
        /// creates boolean for if bun is included
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// creates boolean for if peppers is included
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// creates boolean for if onions is included
        /// </summary>
        private bool onions = true;

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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// sets bun to false if it's not included
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// sets peppers to false if it's not included
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// sets onions to false if it's not included
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
