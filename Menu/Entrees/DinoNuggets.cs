/*  TRexKingBurger.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {

        ///<Summary>
        ///int counter for number of nuggets ordered
        ///</Summary>
        public int nuggetCount = 6;

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
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
            Price = 4.25;
            Calories = 354;
        }
        /// <summary>
        /// adds chicken nugget to ingredients and changes the price and calories to correct.
        /// </summary>
        public void AddNugget()
        {
            this.Price = Price + .25;
            this.Calories = Calories + 59;
            nuggetCount = nuggetCount + 1;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the name
        /// </summary>
        /// <returns>Entree name</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggetCount > 6)
                {
                    special.Add($"{nuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

    }
}
