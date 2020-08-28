/*
 * Author: Mason Dunsmore
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// returns the price of the philly poacher
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }
        /// <summary>
        /// returns the number of calories in the philly poacher
        /// </summary>
        public double Calories
        {
            get { return 784; }
        }
        /// <summary>
        /// returns the special instrutions for the philly poacher
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <summary>
        /// returns whether or not to have sirloin.
        /// </summary>
        public bool Sirloin { get; set; }
        /// <summary>
        /// returns whether or not to have onion
        /// </summary>
        public bool Onion { get; set; }
        /// <summary>
        /// returns whether or not to have roll
        /// </summary>
        public bool Roll { get; set; }
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
