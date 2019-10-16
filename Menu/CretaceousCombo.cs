/*  CretaceousCombo.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class definition for  combos including entree, side, and drink
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Entree entree;
        public Entree Entree
        {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }

        private Drink drink = new Sodasaurus();
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
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// holds the drink option for combo
        /// </summary>
        public Drink Drink {
            get
            {
                return drink;
            }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
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

        public string Description
        {
            get 
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.Add(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
