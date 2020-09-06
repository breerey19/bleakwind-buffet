using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: CandlehearthCoffee.cs
 * Purpose: Sets properties of prices, calories, size, caffination, and special instructions for Candlehearth Coffee.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Sets defaults for size, ice, cream, and decaf
        /// </summary>
        private Size size = Size.Small;
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// Sets size of Candlehearth Coffee, default small
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Sets price of Candlehearth Coffee
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Candlehearth Coffee
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                throw new NotImplementedException($"Unknown size of {Size}");
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
            }
        }
        /// <summary>
        /// Adds string elements to a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public List<string> SpecialInstructions
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
