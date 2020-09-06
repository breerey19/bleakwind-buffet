using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: MarkarthMilk.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Markarth Milk.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Sets defaults for size and ice
        /// </summary>
        private Size size = Size.Small;
        private bool ice = false;

        /// <summary>
        /// Sets size of Markarth Milk, default small
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
        /// Sets price of Markarth Milk
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Markarth Milk
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
                throw new NotImplementedException($"Unknown size of {Size}");
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
        /// Adds string elements to a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice == true) specialInstructions.Add("Add ice");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size and drink name in a string
        /// </summary>
        /// <returns>
        /// The string describing Markarth Milk
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Markarth Milk";
            return details;
        }
    }
}
