using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: PhillyPoacher.cs
 * Purpose: Sets properties of prices, calories, and special instructions for the Philly Poacher.
 * Also includes a ToString override.
 */

namespace Data.Entree
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Sets price of Philly Poacher
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Sets calories of Philly Poacher
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Sets ingredient values to true as default
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Sets value of sirloin, default is true
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// Sets value of onion, default is true
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Sets value of roll, default is true
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Adds string elementsto a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onions");
                if (!Roll) specialInstructions.Add("Hold roll");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the string of the menu item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
