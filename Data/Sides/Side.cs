﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        
        /// <summary>
        /// The Name without Size in front of it
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gives desscription of item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to preparethe side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
