﻿/*
 * Author: Mason Dunsmore
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Warrior Water
    /// </summary>
    public class WarriorWater
    {
        private Size size = Size.Small;
        /// <summary>
        /// returns the size of drink that the customer ordered
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// returns the price of Warrior Water
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.00;
                else if (size == Size.Medium) return 0.00;
                else return 0.00;
            }
        }
        /// <summary>
        /// returns the calories in Warrior Water
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 0;
                else if (size == Size.Medium) return 0;
                else return 0;
            }
        }
        /// <summary>
        /// returns any special instructions for Warrior Water
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }
        /// <summary>
        /// returns whether or not to have Ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// returns whether or not to add lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// overrides ToString method to return "Size Warrior Water"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Warrior Water";
        }
    }
}