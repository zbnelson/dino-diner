using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PlesiosaurusPattie : Entree
    {
        private bool bun = true;
        private bool mayo = true;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Fish Patty");
                if(bun) ingredients.Add("Whole Wheat Bun");
                if(mayo) ingredients.Add("Mayonnaise");
                return ingredients;
            }
        }

        public PlesiosaurusPattie()
        {
            Price = 5.50;
            Calories = 487;
        }

        public void HoldBun()
        {
            bun = false;
        }

        public void HoldMayo()
        {
            mayo = false;
        }

    }
}
