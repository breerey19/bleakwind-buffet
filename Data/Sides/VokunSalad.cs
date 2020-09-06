using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: VokunSalad.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Vokun Salad.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Sets defaults for size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets size of Vokun Salad, default small
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
        /// Sets price of Vokun Salad
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the price for the size is unknown
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Vokun Salad
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Thrown if the calories for the size is unknown
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
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
            string details = $"{Size} Vokun Salad";
            return details;
        }


    }
}
