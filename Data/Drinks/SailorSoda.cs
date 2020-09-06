/*
 * Author: Mason Dunsmore
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        private Size sizes = Size.Small;
        /// <summary>
        /// returns the size of drink that the customer ordered
        /// </summary>
        public Size Size
        {
            get { return sizes; }
            set { sizes = value; }
        }
        /// <summary>
        /// returns the price of Sailor Soda
        /// </summary>
        public double Price
        {
            get { 
                if (sizes == Size.Small) return 1.42;
                else if (sizes == Size.Medium) return 1.74;
                else return 2.07;
                }
        }
        /// <summary>
        /// returns the calories in Sailor Soda
        /// </summary>
        public uint Calories
        {
            get {
                if (sizes == Size.Small) return 117;
                else if (sizes == Size.Medium) return 153;
                else return 205;
            }
        }
        /// <summary>
        /// returns any special instructions for Sailor Soda
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }
        /// <summary>
        /// returns whether or not to have Ice
        /// </summary>
        public bool Ice { get; set; } = true;

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// returns the Soda Flavor (default cherry)
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// overrides ToString method to return "Size Flavor Sailor Soda"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " " + "Sailor Soda";
        }
    }
}
