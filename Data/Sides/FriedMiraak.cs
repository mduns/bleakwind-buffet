/*
 * Author: Mason Dunsmore
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.ExceptionServices;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// returns the price of Fried Miraak
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Fried Miraak
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns an empty list whenever specialinstructions is called
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// construtor if size needs to be set
        /// </summary>
        /// <param name="size">the size that we want to set it to</param>
        public FriedMiraak(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size is small
        /// </summary>
        public FriedMiraak()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// overrides ToString method to return "Size Fried Miraak"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Fried Miraak";
        }
    }
}