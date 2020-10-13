/*
 * Author: Mason Dunsmore
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Warrior Water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.00;
                    case Size.Medium: return 0.00;
                    case Size.Large: return 0.00;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Warrior Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Warrior Water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }
        private bool ice = true;
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
        /// backing variable for Lemon
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// returns whether or not to add lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }

        private Size size;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// constructor if size needs to be set
        /// </summary>
        /// <param name="size">the size to be set</param>
        public WarriorWater(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public WarriorWater()
        {
            Size = Size.Small;
        }
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