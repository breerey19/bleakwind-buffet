using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Bree Reynoso
 * Class name: ThugsT-Bone.cs
 * Purpose: Sets properties of prices, calories, and special instructions for Thugs T-Bone.
 * Also includes a ToString override.
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone : Entree
    {
        /// <summary>
        /// Sets price of Thugs T-Bone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Sets calories of Thugs T-Bone
        /// </summary>
        public override uint Calories => 982;

        public override string Name => "Thugs T-Bone";

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
        /// returns the string of the menu item
        /// </summary>
        /// <returns>
        /// The string of the entree
        /// </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
