using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: MarkarthMilk.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Markarth Milk.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets defaults for size and ice
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;

        public override string Name => "Markarth Milk";

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
        /// Sets price of Markarth Milk
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
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
            }
        }

        /// <summary>
        /// Sets calories of Markarth Milk
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
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
                if (Ice == true) specialInstructions.Add("Add ice");
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size and drink name in a string
        /// </summary>
        /// <returns>
        /// The string describing Markarth Milk
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Markarth Milk";
            return details;
        }
    }
}
