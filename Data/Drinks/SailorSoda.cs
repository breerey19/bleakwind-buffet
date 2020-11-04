using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: SailorsSoda.cs
 * Purpose: Sets properties of prices, calories, size, flavor, and special instructions for Sailor's Soda.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets defaults for size, ice, and soda flavor
        /// </summary>
        private bool ice = true;
        private SodaFlavor sodaFlavor = SodaFlavor.Cherry;
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;

        public override string Name => "Sailor Soda";

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
        /// Sets price of Sailor's Soda
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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
            }
        }

        /// <summary>
        /// Sets calories of Sailor's Soda
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
            }
        }

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
        /// Sets soda flavor value, default is cherry
        /// </summary>
        public virtual SodaFlavor SodaFlavor
        {
            get
            {
                return sodaFlavor;
            }
            set
            {
                sodaFlavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SodaFlavor"));
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
                return specialInstructions;
            }

        }

        /// <summary>
        /// returns the size, flavor, and drink name in a string
        /// </summary>
        /// <returns>
        /// The string describing Sailor Soda
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} {SodaFlavor} Sailor Soda";
            return details;
        }
    }
}
