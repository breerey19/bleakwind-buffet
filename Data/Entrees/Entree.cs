using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        public abstract string Name { get; }

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Gives desscription of item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
