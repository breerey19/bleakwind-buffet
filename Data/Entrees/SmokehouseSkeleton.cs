using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Sets properties of prices, calories, and special instructions for the Smokehouse Skeleton.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Sets price of Smokehouse Skeleton
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Sets calories of Smokehouse Skeleton
        /// </summary>
        public override uint Calories => 602;

        public override string Name => "Smokehouse Skeleton";

        /// <summary>
        /// Sets ingredient values to true as default
        /// </summary>
        private bool sausagelink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets value of sausage links, default is true
        /// </summary>
        public bool SausageLink
        {
            get { return sausagelink; }
            set { 
                sausagelink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of egg, default is true
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { 
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of hashbrown, default is true
        /// </summary>
        public bool Hashbrowns
        {
            get { return hashbrowns; }
            set { 
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hashbrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Sets value of pancake, default is true
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { 
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                if (!SausageLink) specialInstructions.Add("Hold sausage");
                if (!Egg) specialInstructions.Add("Hold eggs");
                if (!Hashbrowns) specialInstructions.Add("Hold hash browns");
                if (!Pancake) specialInstructions.Add("Hold pancakes");
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
            return "Smokehouse Skeleton";
        }
    }
}
