/*  IMenuItem.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// interface for price, calories, and ingredients list
    /// </summary>
    public interface IMenuItem
    {
        double Price { get; }

        uint Calories { get; }

        List<string> Ingredients { get; }
    }
}
