using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: WarriorWater.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Warrior Water.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets defaults for size, ice, and lemon
        /// </summary>
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        public override Size Size
        {
            get { return this.size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }


        /// <summary>
        /// Sets price of Warrior Water to 0.00 for all sizes
        /// </summary>
        public override double Price => 0.00;

        /// <summary>
        /// Sets calories of Warrior Water to 0 for all sizes
        /// </summary>
        public override uint Calories => 0;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Adds string elements to a new List and returns with special instructions, 
        /// otherwise returns an empty list
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string describing the Warrior Water
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Warrior Water";
            return details;
        }
    }
}
