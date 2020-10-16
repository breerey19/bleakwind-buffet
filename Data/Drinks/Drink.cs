using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }


        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to preparethe drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        //public event PropertyChangedEventHandler PropertyChanged;


        //public abstract string ToString { get; }

    }
}
