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
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// returns the price of Aretino Apple Juice
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Aretino Apple Juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Aretino Apple Juice
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// Constructor if size needs to be set
        /// </summary>
        /// <param name="size">the size to be set</param>
        public AretinoAppleJuice(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public AretinoAppleJuice()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// overrides ToString method to return "Size Aretino Apple Juice"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Aretino Apple Juice";
        }
    }
}