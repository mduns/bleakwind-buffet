/*
 * Author: Mason Dunsmore
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragaonborn Waffle Fries side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class for Dragaonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Dragonborn Waffle Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Dragaonborn Waffle Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
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
        /// Constructor if size need to be set
        /// </summary>
        /// <param name="size">the size that you want to set it to</param>
        public DragonbornWaffleFries(Size size)
        {
            Size = size;
        }
        /// <summary>
        /// constructor if size is small
        /// </summary>
        public DragonbornWaffleFries()
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
                description = "Crispy fried potato waffle fries.";
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
        /// overrides ToString method to return "Size Dragaonborn Waffle Fries"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + "Dragonborn Waffle Fries";
        }
    }
}