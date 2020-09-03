using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: WarriorWater.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Warrior Water.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Sets defaults for size, ice, and lemon
        /// </summary>
        private Size size = Size.Small;
        private bool ice = true;
        private bool lemon = false;

        /// <summary>
        /// Sets size of Warrior Water, default small
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
        /// Sets price of Warrior Water to 0.00 for all sizes
        /// </summary>
        public double Price => 0.00;

        /// <summary>
        /// Sets calories of Warrior Water to 0 for all sizes
        /// </summary>
        public uint Calories => 0;

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
        /// Sets value of lemon, default is false
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
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
                if (Lemon == true) specialInstructions.Add("Add lemon");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size and drink name in a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string details = $"{Size} Warrior Water";
            return details;
        }
    }
}
