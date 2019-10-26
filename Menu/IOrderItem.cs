/*  IOrderItem.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// interface for price, Description, and Special string array
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}