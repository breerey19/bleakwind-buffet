/*
 * Author: Bree Reynoso
 * Class name: IOrderItem.cs
 * Purpose: Creates an interface for ordering menu items
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface with Price, Calories, and SpecialInstructions properties
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }
        uint Calories { get; }

        //string ToString { get; }

        List<string> SpecialInstructions { get; }
    }
}
