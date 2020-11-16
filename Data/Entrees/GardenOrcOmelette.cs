/*
 * Author: Mason Dunsmore
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        private bool broccoli = true;
        /// <summary>
        /// returns whether or not to have broccoli.
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool mushrooms = true;
        /// <summary>
        /// returns whether or not to have mushrooms.
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool tomato = true;
        /// <summary>
        /// returns whether or not to have tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool cheddar = true;
        /// <summary>
        /// returns whether or not to have cheddar.
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
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
        /// overrides to ToString method to return "Garden Orc Omelette"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

