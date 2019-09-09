using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        int nuggetCount = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.Ingredients.Add("Chicken Nugget");
            this.Price = Price + .25;
            this.Calories = Calories + 59;
        }

    }
}
