﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
/*
 * Author: Bree Reynoso
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Dragonborn Waffle Fries.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Sets defaults for size
        /// </summary>

        /// <summary>
        /// Sets price of Dragonborn Waffle Fries
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
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
            }
        }

        /// <summary>
        /// Sets calories of Dragonborn Waffle Fries
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
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
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
        /// returns the size aand string name
        /// </summary>
        /// <returns>
        /// The string describing the side
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Dragonborn Waffle Fries";
            return details;
        }
    }
}
