using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: SailorsSoda.cs
 * Purpose: Sets properties of prices, calories, size, flavor, and special instructions for Sailor's Soda.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Sets defaults for size, ice, and soda flavor
        /// </summary>
        private Size size = Size.Small;
        private bool ice = true;
        private SodaFlavor sodaFlavor = SodaFlavor.Cherry;

        /// <summary>
        /// Sets size of Sailor's Soda, default small
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
        /// Sets price of Sailor's Soda
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Sailor's Soda
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets value of ice, default is true
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
        /// Sets soda flavor value, default is cherry
        /// </summary>
        public SodaFlavor SodaFlavor
        {
            get
            {
                return sodaFlavor;
            }
            set
            {
                sodaFlavor = value;
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
                if (!Ice) specialInstructions.Add("Hold ice");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size, flavor, and drink name in a string
        /// </summary>
        /// <returns>
        /// The string describing Sailor Soda
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} {SodaFlavor} Sailor Soda";
            return details;
        }
    }
}
