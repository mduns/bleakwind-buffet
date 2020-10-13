/*Author: Mason Dunsmore
 * Class: Entree.cs
 * Purpose: create a base class representing the common properties of entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// the price of the entree in US dollars
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions to perform on the entree
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
