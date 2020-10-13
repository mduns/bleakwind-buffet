/*Author: Mason Dunsmore
 * Class: Side.cs
 * Purpose: create a base class representing the common properties of sides
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// a base class representing the common properties of sides
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// the size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the side in US dollars
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions to perform on the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Converts ToString to property instead of method so it can be bound in the GUI
        /// </summary>
        public string Name
        {
            get { return this.ToString(); }
        }
    }
}
