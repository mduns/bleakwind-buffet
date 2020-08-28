/*
 * Author: Mason Dunsmore
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree
 */
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// returns the price of the thugs t bone
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }
        /// <summary>
        /// returns the number of calories in the thugs t bone
        /// </summary>
        public double Calories
        {
            get { return 982; }
        }
        /// <summary>
        /// returns the special instrutions for the philly poacher
        /// </summary>
        public List<string> SpecialInstructions
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
