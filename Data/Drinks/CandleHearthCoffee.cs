/*
 * Author: Mason Dunsmore
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Candlehearth Coffee 
    /// </summary>
    public class CandlehearthCoffee
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
        /// returns the price of Candlehearth Coffee
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 0.75;
                else if (sizes == Size.Medium) return 1.25;
                else return 1.75;
            }
        }
        /// <summary>
        /// returns the calories in Candlehearth Coffee
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 7;
                else if (sizes == Size.Medium) return 10;
                else return 20;
            }
        }
        /// <summary>
        /// returns any special instructions for Candlehearth Coffee
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// returns whether or not to have Ice
        /// </summary>
        public bool Ice { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// overrides ToString method to return "Size [Decaf] Candlehearth Coffee"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            return Size + " " + "Candlehearth Coffee";
        }
    }
}
