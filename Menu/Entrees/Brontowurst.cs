﻿/*  Brontowurst.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
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
        
        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
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
            Price = 5.36;
            Calories = 498;
        }

        /// <summary>
        /// sets bun to false if it's not included
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets peppers to false if it's not included
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets onions to false if it's not included
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the name
        /// </summary>
        /// <returns>Entree name</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun)
                { special.Add("Hold Bun"); }
                if (!onions)
                { special.Add("Hold Onions"); }
                if (!peppers)
                { special.Add("Hold Peppers"); }
                return special.ToArray();
            }
        }
    }
}
