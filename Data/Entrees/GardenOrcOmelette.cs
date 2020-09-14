﻿/*
 * Author: Mason Dunsmore
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree
 */
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// returns the price of the garden orc omelette
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }
        private uint calories = 404;
        /// <summary>
        /// returns the number of calories in the garden orc omelette.
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// returns the special instrutions for the garden orc omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        /// <summary>
        /// returns whether or not to have broccoli.
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// returns whether or not to have mushrooms.
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// returns whether or not to have tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// returns whether or not to have cheddar.
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// overrides to ToString method to return "Garden Orc Omelette"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

