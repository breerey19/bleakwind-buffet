using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: VokunSalad.cs
 * Purpose: Sets properties of prices, calories, size, and ToString override for Vokun Salad.
 */

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, INotifyPropertyChanged
    {
        private Size size = Size.Small;
        public event PropertyChangedEventHandler PropertyChanged;

        public override string Name => "Vokun Salad";

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
        /// Sets price of Vokun Salad
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }
                
            }
        }

        /// <summary>
        /// Sets calories of Vokun Salad
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
        /// returns the size and string name
        /// </summary>
        /// <returns>
        /// The string describing the side
        /// </returns>
        public override string ToString()
        {
            string details = $"{Size} Vokun Salad";
            return details;
        }


    }
}
