/* Author: Mason Dunsmore
 * Class: IOrderItem.cs
 * Purpose: create an interface with price, calories, and special instructions in it
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// an interface representing common properties between classes
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// the price of an entree, side, or drink
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the calories of an entree, side, or drink
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// the special instructions to be used on an entree, side, or drink
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// the description of the item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// the category of the item (entree, side, drink)
        /// </summary>
        string Category { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
