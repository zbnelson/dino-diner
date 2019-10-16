/*  tyrannotea.cs
*   Author: Zachary Nelson
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines properties for PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    { 
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// An event handler for PropertyChanged events for Special and Ingredients
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// sets default price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }

        /// <summary>
        /// sets peanutbutter to false if it is not wanted
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// sets Jelly to false if it is not wanted
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to correctly return the string including the name
        /// </summary>
        /// <returns>Entree name</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// gets the description of the entree by calling the overrided ToString method
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// adds the special menu instructions to a list and returns the list as an array.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter)
                    special.Add("Hold Peanut Butter");
                if (!jelly)
                    special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
