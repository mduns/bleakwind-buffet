/*
 * Author: Mason Dunsmore
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Candlehearth Coffee 
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Candlehearth Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Candlehearth Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Candlehearth Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
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
        /// returns whether or not to have cream
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
        private bool decaf = false;
        /// <summary>
        /// returns whether or not to have decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// constructor if size needs to be set 
        /// </summary>
        /// <param name="size">the size to be set</param>
        public CandlehearthCoffee(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public CandlehearthCoffee()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// overrides ToString method to return "Size [Decaf] Candlehearth Coffee"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            return Size + " " + "Candlehearth Coffee";
        }
    }
}
