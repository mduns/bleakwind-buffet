/*
 * Author: Mason Dunsmore
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Warrior Water
    /// </summary>
    public class VokunSalad
    {
        private Size sizes = Size.Small;
        /// <summary>
        /// returns the size of side that the customer ordered
        /// </summary>
        public Size Size
        {
            get { return sizes; }
            set { sizes = value; }
        }
        /// <summary>
        /// returns the price of Vokun Salad
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 0.93;
                else if (sizes == Size.Medium) return 1.28;
                else return 1.82;
            }
        }
        /// <summary>
        /// returns the calories in Vokun Salad
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 41;
                else if (sizes == Size.Medium) return 52;
                else return 73;
            }
        }
        /// <summary>
        /// returns an empty list whenever specialinstructions is called
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// overrides ToString method to return "Size Vokun Salad"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Vokun Salad";
        }
    }
}