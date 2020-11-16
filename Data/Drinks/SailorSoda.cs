/*
 * Author: Mason Dunsmore
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of Sailor Soda
        /// </summary>
        public override double Price
        {
            get {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns the calories in Sailor Soda
        /// </summary>
        public override uint Calories
        {
            get {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }
        /// <summary>
        /// returns any special instructions for Sailor Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
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

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// returns the Soda Flavor (default cherry)
        /// </summary>
        public override SodaFlavor Flavor
        {
            get { return flavor; }
            set 
            { 
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
        /// constructor if size and flavor needs to be set
        /// </summary>
        /// <param name="size">the size to be set</param>
        public SailorSoda(Size size, SodaFlavor soda)
        {
            Size = size;
            Flavor = soda;
        }
        /// <summary>
        /// constructor if size does not need to be set
        /// </summary>
        public SailorSoda()
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
                description = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
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
        ///<summary>
        /// overrides ToString method to return "Size Flavor Sailor Soda"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " " + "Sailor Soda";
        }
    }
}
