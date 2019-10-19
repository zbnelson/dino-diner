/*  Order.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// holds the subtotal cost
        /// </summary>
        private double totalPrice = 0;

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// constructor for order
        /// </summary>
        public Order() { }

        /// <summary>
        /// get set for subtotal cost that makes sure it is non negative
        /// </summary>
        public double SubtotalCost
        {
            get
            {
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
        /// get, protected set for sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

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
