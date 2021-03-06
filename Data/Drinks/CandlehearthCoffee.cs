﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: CandlehearthCoffee.cs
 * Purpose: Sets properties of prices, calories, size, caffination, and special instructions for Candlehearth Coffee.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets defaults for size, ice, cream, and decaf
        /// </summary>
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// name of item without decaf or size
        /// </summary>
        public override string Name => "Candlehearth Coffee";

        /// <summary>
        /// Description of the menu item
        /// </summary>
        public override string Description => "Fair trade, fresh ground dark roast coffee.";

        /// <summary>
        /// returns size of drink
        /// </summary>
        public override Size Size
        {
            get { return this.size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// Sets price of Candlehearth Coffee
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
            }
                
            }
        }

        /// <summary>
        /// Sets calories of Candlehearth Coffee
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default:  throw new NotImplementedException($"Unknown size of {Size}");
            }
                
            }
        }

        /// <summary>
        /// Sets value of decaf, default is false
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
               decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));

            }
        }
        /// <summary>
        /// Sets value of ice, default is false
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of cream, default is false
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Adds string elements to a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice == true) specialInstructions.Add("Add ice");
                if (RoomForCream == true) specialInstructions.Add("Add cream");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size and drink name in a string
        /// </summary>
        /// <returns>
        /// The string describing the Candlehearth Coffee
        /// </returns>
        public override string ToString()
        {
            if(Decaf == true)
            {
                string details = $"{Size} Decaf Candlehearth Coffee";
                return details;
            }
            else
            {
                string details = $"{Size} Candlehearth Coffee";
                return details;
            }

        }
    }
}
