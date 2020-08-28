/*
 * Author: Mason Dunsmore
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        private Size sizes = Size.Small;
        /// <summary>
        /// returns the size of side that the customer ordered
        /// </summary>
        public Size Sizes
        {
            get { return sizes; }
            set { sizes = value; }
        }
        /// <summary>
        /// returns the price of Fried Miraak
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 1.78;
                else if (sizes == Size.Medium) return 2.01;
                else return 2.88;
            }
        }
        /// <summary>
        /// returns the calories in Fried Miraak
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 151;
                else if (sizes == Size.Medium) return 236;
                else return 306;
            }
        }

        /// <summary>
        /// overrides ToString method to return "Size Fried Miraak"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Sizes + " " + "Fried Miraak";
        }
    }
}