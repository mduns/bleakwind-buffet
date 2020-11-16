/*
 * Author: Mason Dunsmore
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of the philly poacher
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }
        private uint calories = 784;
        /// <summary>
        /// returns the number of calories in the philly poacher
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// returns the special instrutions for the philly poacher
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        private bool sirloin = true;
        /// <summary>
        /// returns whether or not to have sirloin.
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool onion = true;
        /// <summary>
        /// returns whether or not to have onion
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set 
            { 
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool roll = true;
        /// <summary>
        /// returns whether or not to have roll
        /// </summary> 
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// returns the description of the item
        /// </summary>
        private string description;
        public string Description
        {
            get
            {
                description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
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
                return "Entree";
            }
        }
        /// <summary>
        /// overrides to string method to "Philly Poacher"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
