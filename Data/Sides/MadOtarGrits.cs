/*
 * Author: Mason Dunsmore
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Mad Otar Grits
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Mad Otar Grits
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException("Should never be reached");
                }
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
        /// constructor if size needs to be set
        /// </summary>
        /// <param name="size">what the size we want to set it to is</param>
        public MadOtarGrits(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public MadOtarGrits()
        {
            Size = Size.Small;
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