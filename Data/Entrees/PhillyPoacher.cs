﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: PhillyPoacher.cs
 * Purpose: Sets properties of prices, calories, and special instructions for the Philly Poacher.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets price of Philly Poacher
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Sets calories of Philly Poacher
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// name of item
        /// </summary>
        public override string Name => "Philly Poacher";

        /// <summary>
        /// Description of the menu item
        /// </summary>
        public override string Description => "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";


        /// <summary>
        /// Sets ingredient values to true as default
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets value of sirloin, default is true
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { 
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of onion, default is true
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { 
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of roll, default is true
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { 
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Adds string elementsto a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string of the entree
        /// </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
