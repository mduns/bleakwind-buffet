/*
 * Author: Mason Dunsmore
 * Class name: Combo.cs
 * Purpose: Class used to represent the Combo that the customer wants
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// EventHandler for if the Property Changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private uint calories = 0;
        /// <summary>
        /// Total calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                calories = drink.Calories + side.Calories + entree.Calories;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                return calories;
            }
        }
        /// <summary>
        /// Total price of the combo, minus $1 
        /// </summary>
        private double price = 0.0;
        public double Price
        {
            get
            {
                price = drink.Price + side.Price + entree.Price - 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                return price;
            }
        }
        /// <summary>
        /// All of the special instructions and item names in the combo
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

        private Drink drink;
        /// <summary>
        /// Drinks in the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                if(drink != null)
                {
                    SpecialInstructions.Remove(drink.ToString());
                    foreach (string i in drink.SpecialInstructions)
                    {
                        SpecialInstructions.Remove(i);
                    }
                }
                drink = value;
                SpecialInstructions.Add(drink.ToString());
                foreach(string j in drink.SpecialInstructions)
                {
                    SpecialInstructions.Add(j);
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// Sides in the combo
        /// </summary>
        private Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                if(side != null)
                {
                    SpecialInstructions.Remove(side.ToString());
                    foreach (string i in side.SpecialInstructions)
                    {
                        SpecialInstructions.Remove(i);
                    }
                }
                side = value;
                SpecialInstructions.Add(side.ToString());
                foreach (string j in side.SpecialInstructions)
                {
                    SpecialInstructions.Add(j);
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// Entree in the combo
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get { return entree; }
            set
            {
                if(entree != null)
                {
                    SpecialInstructions.Remove(entree.ToString());
                    foreach (string i in entree.SpecialInstructions)
                    {
                        SpecialInstructions.Remove(i);
                    }
                }
                entree = value;
                SpecialInstructions.Add(entree.ToString());
                foreach (string j in entree.SpecialInstructions)
                {
                    SpecialInstructions.Add(j);
                }
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
