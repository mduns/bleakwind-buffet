/*
 * Author: Mason Dunsmore
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
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
        /// returns the price of Mad Otar Grits
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 1.22;
                else if (sizes == Size.Medium) return 1.58;
                else return 1.93;
            }
        }
        /// <summary>
        /// returns the calories in Mad Otar Grits
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 105;
                else if (sizes == Size.Medium) return 142;
                else return 179;
            }
        }

        /// <summary>
        /// overrides ToString method to return "Size Mad Otar Grits"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Mad Otar Grits";
        }
    }
}