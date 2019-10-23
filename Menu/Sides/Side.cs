/*  Sides.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using DinoDiner.Menu;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class that gets/sets the price, calories and ingredients list for sides.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event handler for PropertyChanged events for Special and Ingredients
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients {
            get {return new List<string>(ingredients);}
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size {
            get { return Size; }
            set
            {
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
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
                return new string[0];
            }
        }

    }
}
