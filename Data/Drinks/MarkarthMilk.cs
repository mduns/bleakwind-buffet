﻿/*
 * Author: Mason Dunsmore
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Markarth Milk
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Markarth Milk
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Markarth Milk 
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

        private bool ice = false;
        /// <summary>
        /// returns whether or not to have Ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// overrides the size enum
        /// </summary>
        private Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        /// <summary>
        /// constructor to set size
        /// </summary>
        /// <param name="size">the size to be set</param>
        public MarkarthMilk(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public MarkarthMilk()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// returns the description of the item
        /// </summary>
        private string description;
        public string Description
        {
            get
            {
                description = "Hormone-free organic 2% milk.";
                return description;
            }
        }
        /// <summary>
        /// The category of the item
        /// </summary>
        public string Category
        {
            get
            {
                return "Drink";
            }
        }
        /// <summary>
        /// overrides ToString method to return "Size Markarth Milk"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Markarth Milk";
        }
    }
}
