/*
 * Author: Mason Dunsmore
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        private Size sizes = Size.Small;
        /// <summary>
        /// returns the size of drink that the customer ordered
        /// </summary>
        public Size Sizes
        {
            get { return sizes; }
            set { sizes = value; }
        }
        /// <summary>
        /// returns the price of Markarth Milk
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 1.05;
                else if (sizes == Size.Medium) return 1.11;
                else return 1.22;
            }
        }
        /// <summary>
        /// returns the calories in Markarth Milk
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 56;
                else if (sizes == Size.Medium) return 72;
                else return 93;
            }
        }
        /// <summary>
        /// returns any special instructions for Markarth Milk 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }
        /// <summary>
        /// returns whether or not to have Ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// overrides ToString method to return "Size Markarth Milk"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Sizes + " " + "Markarth Milk";
        }
    }
}
