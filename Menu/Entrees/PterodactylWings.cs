/*  PterodactylWings.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
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
            Price = 7.21;
            Calories = 318;
        }
    }
}
