using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: GardenOrcOmelette.cs
 * Purpose: Sets properties of prices, calories, and special instructions for the Garden Orc Omelette.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets price of Garden Orc Omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Sets calories of Garden Orc Omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Sets ingredient values to true as default
        /// </summary>
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets value of broccoli, default is true
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { 
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of mushrooms, default is true
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { 
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of tomato, default is true
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { 
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of cheddar, default is true
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { 
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
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
            return "Garden Orc Omelette";
        }
    }
}
