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
    public class DragonbornWaffleFries
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
        /// returns the price of Dragonborn Waffle Fries
        /// </summary>
        public double Price
        {
            get
            {
                if (sizes == Size.Small) return 0.42;
                else if (sizes == Size.Medium) return 0.76;
                else return 0.96;
            }
        }
        /// <summary>
        /// returns the calories in Dragaonborn Waffle Fries
        /// </summary>
        public uint Calories
        {
            get
            {
                if (sizes == Size.Small) return 77;
                else if (sizes == Size.Medium) return 89;
                else return 100;
            }
        }

        /// <summary>
        /// overrides ToString method to return "Size Dragaonborn Waffle Fries"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Dragaonborn Waffle Fries";
        }
    }
}