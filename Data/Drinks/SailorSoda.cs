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
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// returns the price of Sailor Soda
        /// </summary>
        public override double Price
        {
            get {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Sailor Soda
        /// </summary>
        public override uint Calories
        {
            get {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Sailor Soda
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// constructor if size and flavor needs to be set
        /// </summary>
        /// <param name="size">the size to be set</param>
        public SailorSoda(Size size, SodaFlavor soda)
        {
            Size = size;
            Flavor = soda;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public SailorSoda()
        {
            Size = Size.Small;
        }
        ///<summary>
        /// overrides ToString method to return "Size Flavor Sailor Soda"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " " + "Sailor Soda";
        }
    }
}
