/*  CretaceousCombo.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class definition for  combos including entree, side, and drink
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        public Entree Entree { get; set; }
        /// <summary>
        /// Holds the side option for the combo
        /// </summary>
        private Side side;

        public Side Side {

            get
            {
                return side;
            }
            set
            {
                this.side = value;
                this.side.Size = this.size;
            }
        }

        /// <summary>
        /// holds the drink option for combo
        /// </summary>
        private Drink drink;

        public Drink Drink {
            get
            {
                return drink;
            }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
            }
        }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// holds size of the combo
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// constructor for CretaceousCombo
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// override the to string method to correctly return the combo name
        /// </summary>
        /// <returns>combo name</returns>
        public override string ToString()
        {
            return $"{Entree} Combo"; ;
        }
    }
}
