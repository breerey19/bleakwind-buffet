using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: MadOtarGrits.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for MadOtarGrits.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Sets defaults for size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets size of Mad Otar Grits, default small
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
        /// Sets price of Mad Otar Grits
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Mad Otar Grits
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
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
        /// returns the size aand string name
        /// </summary>
        /// <returns>
        /// The string describing the side
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Mad Otar Grits";
            return details;
        }
    }
}
