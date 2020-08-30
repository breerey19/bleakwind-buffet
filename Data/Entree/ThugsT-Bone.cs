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

namespace Data.Entree
{
    public class ThugsT_Bone
    {
        /// <summary>
        /// Sets price of Thugs T-Bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Sets calories of Thugs T-Bone
        /// </summary>
        public uint Calories => 982;
        
        /// <summary>
        /// No instructions, empty list should be returned always
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
