using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

/*
 * Author: Bree Reynoso
 * Class name: FriedMiraak.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Fried Miraak.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side
    {
        /// <summary>
        /// Sets price of Fried Miraak
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
               
            }
        }

        /// <summary>
        /// Sets calories of Fried Miraak
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
               
            }
        }

        /// <summary>
        /// No instructions, empty list should be returned always
        /// </summary>
        public override List<string> SpecialInstructions
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
