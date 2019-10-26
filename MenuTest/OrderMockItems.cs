/* OrderMockItems.cs
*  Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderMockItems : IOrderItem
    {
        public double Price { get; set; }

        public string Description { get; set; }

        public string[] Special { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public class Mockitem1 : IOrderItem
        {
            public double Price { get; set; } = 4.50;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public Mockitem1() { }

            public Mockitem1(double price)
            {
                this.Price = price;
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }

        public class Mockitem2 : IOrderItem
        {
            public double Price { get; set; } = -400;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public Mockitem2() { }

            public Mockitem2(double price)
            {
                this.Price = price;
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }

        public class Mockitem3 : IOrderItem
        {
            public double Price { get; set; } = 1.50;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public Mockitem3() { }

            public Mockitem3(double price)
            {
                this.Price = price;
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }

    }
}
