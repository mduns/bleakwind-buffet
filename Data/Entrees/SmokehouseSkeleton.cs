﻿/*
 * Author: Mason Dunsmore
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of the Thalmor Triple
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }
        private uint calories = 602;
        /// <summary>
        /// returns the amount of calories in the Thalmor Triple
        /// </summary>
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        private bool sausageLink = true;
        /// <summary>
        /// returns whether or not to have sausage links. Adds to special instructions if no sausage links
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool egg = true;
        /// <summary>
        /// returns whether or not to have eggs. Adds to special instructions if no egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool hashBrowns = true;
        /// <summary>
        /// returns whether or not to have hashbrowns. Adds to special instructions if no hashbrowns.
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool pancake = true;
        /// <summary>
        /// returns whether or not to have pancakes. Adds to special instructions if no pancake.
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                description = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side." +
                    " Topped with the syrup of your choice.";
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
        /// overrides ToString method ot return "Smokehouse Skeleton"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}