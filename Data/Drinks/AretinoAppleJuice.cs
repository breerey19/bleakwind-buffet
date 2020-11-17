using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: AretinoAppleJuice.cs
 * Purpose: Sets properties of prices, calories, size, and special instructions for Aretino Apple Juice.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets defaults for size and ice
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;

        /// <summary>
        /// name of item without size
        /// </summary>
        public override string Name => "Aretino Apple Juice";

        /// <summary>
        /// Description of the menu item
        /// </summary>
        public override string Description => "Fresh squeezed apple juice.";

        /// <summary>
        /// returns the size of drink
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
        /// Sets price of Aretino Apple Juice
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException($"Unknown size of {Size}");
                }               

            }


        }

        /// <summary>
        /// Sets calories of Aretino Apple Juice
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
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
        /// The string describing Aretino Apple Juice
        /// </returns>
        public override string ToString()
        {
            return Size.ToString() + " Aretino Apple Juice";
        }
    }
}
