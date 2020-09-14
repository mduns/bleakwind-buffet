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
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// returns the price of Candlehearth Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Candlehearth Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Candlehearth Coffee
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <summary>
        /// returns whether or not to have cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// returns whether or not to have decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// constructor if size needs to be set 
        /// </summary>
        /// <param name="size">the size to be set</param>
        public CandlehearthCoffee(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public CandlehearthCoffee()
        {
            Size = Size.Small;
        }
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
