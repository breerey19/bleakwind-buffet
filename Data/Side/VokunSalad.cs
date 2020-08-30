using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: VokunSalad.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Vokun Salad.
 */


namespace Data.Side
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
        /// returns the size and string name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Size == Size.Large) return "Large Vokun Salad";
            if(Size == Size.Medium) return "Medium Vokun Salad";
            if(Size == Size.Small) return "Small Vokun Salad";
            throw new NotImplementedException($"Unknown size of {Size}");
        }


    }
}
