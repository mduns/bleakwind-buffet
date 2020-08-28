/*
 * Author: Mason Dunsmore
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
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
        /// returns the price of Aretino Apple Juice
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 0.62;
                else if (sizes == Size.Medium) return 0.87;
                else return 1.01;
            }
        }
        /// <summary>
        /// returns the calories in Aretino Apple Juice
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 44;
                else if (sizes == Size.Medium) return 88;
                else return 132;
            }
        }
        /// <summary>
        /// returns any special instructions for Aretino Apple Juice
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
        /// overrides ToString method to return "Size Aretino Apple Juice"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Sizes + " " + "Aretino Apple Juice";
        }
    }
}