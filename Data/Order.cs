/*
 * Author: Mason Dunsmore
 * Class name: Order.cs
 * Purpose: Class used to represent the order that the customer wants
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        private static int nextOrderNumber = 1;
        public Order()
        { 
            CollectionChanged += CollectionChangedListener;
            number = nextOrderNumber;
            nextOrderNumber++;
        }
        private double salesTaxRate = 0.12;
        /// <summary>
        /// the sales tax rate (12%)
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem i in this)
                {
                    subtotal += i.Price;
                }
                return subtotal;
            }
        }
        private uint calories;
        /// <summary>
        /// Returns all of the calories of the IOrderItems in the class
        /// </summary>
        public uint Calories
        {
            get
            {
                foreach(IOrderItem i in this)
                {
                    calories += i.Calories;
                }
                return calories;
            }
        }
        private double tax;
        /// <summary>
        /// The tax added to each order
        /// </summary>
        public double Tax
        {
            get
            {
                tax = Subtotal * salesTaxRate;
                return tax;
            }
        }
        private double total;
        /// <summary>
        /// The total of the order
        /// </summary>
        public double Total
        {
            get
            {
                total = Subtotal + tax;
                return total;
            }
        }
        private int number;
        /// <summary>
        /// The order number for this order
        /// </summary>
        public int Number
        {
            get { return number; }
        }

        /// <summary>
        /// Notifies if any item in the entire collection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChanged.Reset not supported");
            }
        }
        /// <summary>
        /// Notifies if any item is changed and updates CompleteCount and IncompleteCount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }      
        }
        /// <summary>
        /// adds item to the Order
        /// </summary>
        /// <param name="item">item to be added to Order</param>
        public new void Add(IOrderItem item)
        {
            base.Add(item);
            //CollectionChanged += CollectionChangedListener;
        }
        /// <summary> 
        /// Removes item from Order
        /// </summary>
        /// <param name="item">item to be removed from the Order</param>
        public new bool Remove(IOrderItem item)
        {
            foreach (IOrderItem i in this)
            {
                if (i == item)
                {
                    base.Remove(item);
                    //CollectionChanged -= CollectionChangedListener;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Clears the order
        /// </summary>
        public new void Clear()
        {
            foreach (IOrderItem i in this)
            {
                this.Remove(i);
            }
        }
    }
}
