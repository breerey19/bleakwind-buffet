using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: AretinoAppleJuice.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Aretino Apple Juice.
 * Also includes a ToString override.
 */

namespace Data.Drink
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Sets defaults for size and ice
        /// </summary>
        private Size size = Size.Small;
        private bool ice = false;

        /// <summary>
        /// Sets size of Aretino Apple Juice, default small
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
        /// Sets price of Aretino Apple Juice
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Sets calories of Aretino Apple Juice
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
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
        /// <returns></returns>
        public override string ToString()
        {
            string details = $"{Size} Aretino Apple Juice";
            return details;
        }
    }
}
