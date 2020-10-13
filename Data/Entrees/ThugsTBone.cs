/*
 * Author: Mason Dunsmore
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the price of the thugs t bone
        /// </summary>
        public override double Price
        {
            get { return 6.44; }
        }
        private uint calories = 982;
        /// <summary>
        /// returns the number of calories in the thugs t bone
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// returns the special instrutions for the thugs t bone
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
        /// overrides to string method to "Thugs T-Bone"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
