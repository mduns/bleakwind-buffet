/* Author: Mason Dunsmore
 * Class: Drink.cs
 * Purpose: Create a base class representing the common properties of drinks
 * 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// a base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the drink in US dollars
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions to perform on the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
