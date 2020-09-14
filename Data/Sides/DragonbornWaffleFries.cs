/*
 * Author: Mason Dunsmore
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragaonborn Waffle Fries side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Dragaonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// returns the price of Dragonborn Waffle Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Dragaonborn Waffle Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
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
        /// Constructor if size need to be set
        /// </summary>
        /// <param name="size">the size that you want to set it to</param>
        public DragonbornWaffleFries(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size is small
        /// </summary>
        public DragonbornWaffleFries()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// overrides ToString method to return "Size Dragaonborn Waffle Fries"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Dragonborn Waffle Fries";
        }
    }
}