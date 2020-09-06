using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: FriedMiraak.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Fried Miraak.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Sets defaults for size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets size of Fried Miraak, default small
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
        /// Sets price of Fried Miraak
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Fried Miraak
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 151;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// No instructions, empty list should be returned always
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size and string name
        /// </summary>
        /// <returns>
        /// The string describing the side
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Fried Miraak";
            return details;
        }
    }
}
