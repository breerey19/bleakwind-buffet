using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Dragonborn Waffle Fries.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Sets defaults for size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Sets size of Dragonborn Waffle Fries, default small
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
        /// Sets price of Dragonborn Waffle Fries
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.42;
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Large) return 0.96;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Dragonborn Waffle Fries
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// returns the size aand string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string details = $"{Size} Dragonborn Waffle Fries";
            return details;
        }
    }
}
