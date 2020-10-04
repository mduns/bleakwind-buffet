/*
 * Author: Mason Dunsmore
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A 1/4 lb burger with a set price and calories and booleans 
    /// for bun, ketchup, mustard, pickle, and cheese. False if customer doesn't want them
    /// SpecialInstructions list for whatever the customer doesn't want on it
    /// </summary>
	public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the price of the burger
        /// </summary>
        private double price = 6.32;
        public override double Price
        {
            get { return price; }
        }
        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        private uint calories = 743;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// adds the special instructions to a list which can have new instructions added to it
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        private bool bun = true;
        /// <summary>
        /// gets whether or not to have a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }
        private bool ketchup = true;
        /// <summary>
        /// returns whether or not to have ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }
        private bool mustard = true;
        /// <summary>
        /// returns whether or not to have mustard. Adds to special instructions if no mustard.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }
        private bool pickle = true;
        /// <summary>
        ///  returns whether or not to have pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }
        private bool cheese = true;
        /// <summary>
        ///  returns whether or not to have cheese. Adds to special instructions if no cheese.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }
        /// <summary>
        /// overrides to string method to "Briarheart Burger"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
	}
}
