/*
 * Author: Mason Dunsmore
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr entree
 */
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	public class DoubleDraugr
	{
		/// <summary>
		/// returns the price of the double Draugr
		/// </summary>
		public double Price
		{
			get { return 7.32; }
		}
		/// <summary>
		/// returns the amount of calories in the Double Draugr
		/// </summary>
		public uint Calories
		{
			get { return 843; }
		}
        /// <summary>
        /// adds the special instructions to a list which can have new instructions added to it
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }
        /// <summary>
        /// gets whether or not to have a bun
        /// </summary>
        public bool Bun { get; set; }
        /// <summary>
        /// returns whether or not to have ketchup
        /// </summary>
        public bool Ketchup { get; set; }
        /// <summary>
        /// returns whether or not to have mustard. Adds to special instructions if no mustard.
        /// </summary>
        public bool Mustard { get; set; }
        /// <summary>
        ///  returns whether or not to have pickles.
        /// </summary>
        public bool Pickle { get; set; }
        /// <summary>
        ///  returns whether or not to have cheese. Adds to special instructions if no cheese.
        /// </summary>
        public bool Cheese { get; set; }
        /// <summary>
        /// returns whether or not to have tomato. Adds to special instructions if no tomato.
        /// </summary>
        public bool Tomato { get; set; }
        /// <summary>
        /// returns whether or not to have lettuce. Adds to special instructions if no lettuce.
        /// </summary>
        public bool Lettuce { get; set; }
        /// <summary>
        /// returns whether or not to have mayo. Adds to special instructions if no mayo.
        /// </summary>
        public bool Mayo { get; set; }
        /// <summary>
        /// overrides to string method to "Double Draugr"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
