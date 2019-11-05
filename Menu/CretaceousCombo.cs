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
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// event handler for propertychanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
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
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// backing variable for drink
        /// </summary>
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
                side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
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
                drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// gets price of all items in combo plus .25
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }
        }

        /// <summary>
        /// gets calories of all items in combo
        /// </summary>
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

        
        /// <summary>
        /// gets and sets size for all items in combo
        /// </summary>
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
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
            }
        }

        /// <summary>
        /// creates a list of all ingredients in combo
        /// </summary>
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

        /// <summary>
        /// gets the description of the entree by calling the overrided ToString method
        /// </summary>
        public string Description
        {
            get 
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
