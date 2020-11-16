/*
 * Author: Mason Dunsmore
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.ExceptionServices;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        /// returns the description of the item
        /// </summary>
        private string description;
        public string Description
        {
            get
            {
                description = "Perfectly prepared hash brown pancakes.";
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
                return "Side";
            }
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