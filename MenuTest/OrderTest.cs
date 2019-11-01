/* OrderTest.cs
*  Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            Order order = new Order();
            order.Add(new OrderMockItems.Mockitem1());
            order.Add(new OrderMockItems.Mockitem2());
            Assert.Equal<double>(0, order.SubtotalCost);
        }

        [Fact]
        public void SubtotalCostShouldBePositive()
        {
            Order order = new Order();
            order.Add(new OrderMockItems.Mockitem1());
            order.Add(new OrderMockItems.Mockitem3());
            Assert.Equal<double>(6, order.SubtotalCost);
        }
    }
}
