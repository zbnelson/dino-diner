/*  Order.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// holds salestaxrate
        /// </summary>
        private double salesTaxRate = 0;

        /// <summary>
        /// creates a list of iorderitems
        /// </summary>
        private List<IOrderItem> items;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// creates an iorderitem array of items
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// removes an item from list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
            //return items.Remove(item);
        }

        /// <summary>
        /// adds an item to the item list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// notifys when a property is changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// constructor for order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        /// <summary>
        /// sends property changed events when collection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// get set for subtotal cost that makes sure it is non negative
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double totalPrice = 0;
                foreach(IOrderItem i in Items)
                {
                    totalPrice += i.Price;
                }
                if (totalPrice < 0)
                    return 0;
                else
                    return totalPrice;
            }
        }
        
        /// <summary>
        /// get, set for sales tax rate with notifications
        /// </summary>
        public double SalesTaxRate {
            get { return salesTaxRate; }
            set
            {
                if (value < 0) return;
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// getter for sales tax cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return this.SubtotalCost * this.SalesTaxRate;
            }
        }

        /// <summary>
        /// getter for total cost which makes sure it is non negative
        /// </summary>
        public double TotalCost
        {
            get
            {
                return this.SalesTaxCost + this.SubtotalCost;
            }
        }
    }
}
