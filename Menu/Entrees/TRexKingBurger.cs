/*  TRexKingBurger.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
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
        /// <summary>
        /// creates boolean for if lettuce is included
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// creates boolean for if tomato is included
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// creates boolean for if onion is included
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// creates boolean for if mayo is included
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and calories
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        /// sets pickle to false if it's not included
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets ketchup to false if it's not included
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets mustard to false if it's not included
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets mayo to false if it's not included
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets onion to false if it's not included
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets lettuce to false if it's not included
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// sets tomato to false if it's not included
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the name
        /// </summary>
        /// <returns>Entree name</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                    special.Add("Hold Bun");
                if (!pickle)
                    special.Add("Hold Pickles");
                if (!ketchup)
                    special.Add("Hold Ketchup");
                if (!mustard)
                    special.Add("Hold Mustard");
                if (!mayo)
                    special.Add("Hold Mayonnaise");
                if (!onion)
                    special.Add("Hold Onions");
                if (!lettuce)
                    special.Add("Hold Lettuce");
                if (!tomato)
                    special.Add("Hold Tomato");
                return special.ToArray();
            }
        }
    }
}
