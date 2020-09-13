using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: BriarheartBurger.cs
 * Purpose: Sets properties of prices, calories, and special instructions for the Briarheart Burger.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// Sets price of Briarheart Burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Sets calories of Briarheart Burger
        /// </summary>
        public override uint Calories => 734;

        /// <summary>
        /// Sets ingredient values to true as default
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// Sets value of bun, default is true
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// Sets value of ketchup, default is true
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Sets value of mustard, default is true
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Sets value of pickle, default is true
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Sets value of cheese, default is true
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
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
                if (!Bun) specialInstructions.Add("Hold bun");
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
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
            return "Briarheart Burger";
        }


    }
}
