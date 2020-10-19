/*Author: Mason Dunsmore
 * Class: CashAmount.cs
 * Purpose: Data class for the Cash Payment
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class to hold the amount of cash that the customer gives
    /// </summary>
    public class CashAmount: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int hundredAmount = 0;
        /// <summary>
        /// Amount of hundred dollar bills the customer gave you 
        /// </summary>
        public int HundredAmount
        {
            get { return hundredAmount; }
            set
            {
                hundredAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int fiftyAmount = 0;
        /// <summary>
        /// the number of fifty dollar bills the customer gave you
        /// </summary>
        public int FiftyAmount
        {
            get { return fiftyAmount; }
            set
            {
                fiftyAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int twentyAmount = 0;
        /// <summary>
        /// the number of twenty dollar bills the customer gave you
        /// </summary>
        public int TwentyAmount
        {
            get { return twentyAmount; }
            set
            {
                twentyAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int tenAmount = 0;
        /// <summary>
        /// the number of ten dollar bills the customer gave you
        /// </summary>
        public int TenAmount
        {
            get { return tenAmount; }
            set
            {
                tenAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int fiveAmount = 0;
        /// <summary>
        /// the number of five dollar bills the customer gave you
        /// </summary>
        public int FiveAmount
        {
            get { return fiveAmount; }
            set
            {
                fiveAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int oneAmount = 0;
        /// <summary>
        /// the number of dollar bills the customer gave you
        /// </summary>
        public int OneAmount
        {
            get { return oneAmount; }
            set 
            { 
                oneAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int fiftyCentAmount = 0;
        /// <summary>
        /// the number of half dollars the customer gave you
        /// </summary>
        public int FiftyCentAmount
        {
            get { return fiftyCentAmount; }
            set
            {
                fiftyCentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCentAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int twentyFiveCentAmount = 0;
        /// <summary>
        /// the number of quarters the customer gave you
        /// </summary>
        public int TwentyFiveCentAmount
        {
            get { return twentyFiveCentAmount; }
            set
            {
                twentyFiveCentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCentAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int tenCentAmount = 0;
        /// <summary>
        /// the number of dimes the customer gave you
        /// </summary>
        public int TenCentAmount
        {
            get { return tenCentAmount; }
            set
            {
                tenCentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCentAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int fiveCentAmount = 0;
        /// <summary>
        /// the number of nickels the customer gave you
        /// </summary>
        public int FiveCentAmount
        {
            get { return fiveCentAmount; }
            set
            {
                fiveCentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCentAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        private int oneCentAmount = 0;
        /// <summary>
        /// the number of pennies given
        /// </summary>
        public int OneCentAmount
        {
            get { return oneCentAmount; }
            set
            {
                oneCentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCentAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCash"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }
        private int hundredChangeAmount = 0;
        /// <summary>
        /// Amount of hundred dollar bills owed
        /// </summary>
        public int HundredChangeAmount
        {
            get { return hundredChangeAmount; }
            set
            {
                hundredChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredChangeAmount"));
            }
        }

        private int fiftyChangeAmount = 0;
        /// <summary>
        /// the number of fifty dollar bills owed
        /// </summary>
        public int FiftyChangeAmount
        {
            get { return fiftyChangeAmount; }
            set
            {
                fiftyChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCHangeAmount"));
            }
        }

        private int twentyChangeAmount = 0;
        /// <summary>
        /// the number of twenty dollar bills owed
        /// </summary>
        public int TwentyChangeAmount
        {
            get { return twentyChangeAmount; }
            set
            {
                twentyChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyChangeAmount"));
            }
        }

        private int tenChangeAmount = 0;
        /// <summary>
        /// the number of ten dollar bills owed
        /// </summary>
        public int TenChangeAmount
        {
            get { return tenChangeAmount; }
            set
            {
                tenChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenChangeAmount"));
            }
        }

        private int fiveChangeAmount = 0;
        /// <summary>
        /// the number of five dollar bills owed
        /// </summary>
        public int FiveChangeAmount
        {
            get { return fiveChangeAmount; }
            set
            {
                fiveChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveChangeAmount"));
            }
        }

        private int oneChangeAmount = 0;
        /// <summary>
        /// the number of dollar bills owed
        /// </summary>
        public int OneChangeAmount
        {
            get { return oneChangeAmount; }
            set
            {
                oneChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneChangeAmount"));
            }
        }

        private int fiftyCentChangeAmount = 0;
        /// <summary>
        /// the number of half dollars owed
        /// </summary>
        public int FiftyCentChangeAmount
        {
            get { return fiftyCentChangeAmount; }
            set
            {
                fiftyCentChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCentChangeAmount"));
            }
        }

        private int twentyFiveCentChangeAmount = 0;
        /// <summary>
        /// the number of quarters owed
        /// </summary>
        public int TwentyFiveCentChangeAmount
        {
            get { return twentyFiveCentChangeAmount; }
            set
            {
                twentyFiveCentChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCentChangeAmount"));
            }
        }

        private int tenCentChangeAmount = 0;
        /// <summary>
        /// the number of dimes owed
        /// </summary>
        public int TenCentChangeAmount
        {
            get { return tenCentChangeAmount; }
            set
            {
                tenCentChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCentChangeAmount"));
            }
        }

        private int fiveCentChangeAmount = 0;
        /// <summary>
        /// the number of nickels owed
        /// </summary>
        public int FiveCentChangeAmount
        {
            get { return fiveCentChangeAmount; }
            set
            {
                fiveCentChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCentChangeAmount"));
            }
        }

        private int oneCentChangeAmount = 0;
        /// <summary>
        /// the number of pennies owed
        /// </summary>
        public int OneCentChangeAmount
        {
            get { return oneCentChangeAmount; }
            set
            {
                oneCentChangeAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCentChangeAmount"));
            }
        }

        private double totalDue = 0;
        /// <summary>
        /// The total amount of cash that is due from the order
        /// </summary>
        public double TotalDue
        {
            get { return totalDue; }
            set 
            { 
                totalDue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalDue"));
            }
        }

        private double totalCash = 0;
        /// <summary>
        /// The total amount of cash that is given from the customer
        /// </summary>
        public double TotalCash
        {
            get
            {
                totalCash = 100 * HundredAmount + 50 * FiftyAmount + 20 * TwentyAmount + 10 * TenAmount + 5 * FiveAmount + OneAmount + .5 * FiftyCentAmount
                    + .25 * TwentyFiveCentAmount + .10 * TenCentAmount + .05 * FiveCentAmount + .01 * OneCentAmount;
                return totalCash;
            }
        }
        private double amountOwed = 0;
        /// <summary>
        /// the amount of cash the customer still needs to pay
        /// </summary>
        public double AmountOwed
        {
            get
            {
                if(TotalDue - TotalCash > 0)
                {
                    amountOwed = TotalDue - TotalCash;
                    return amountOwed;
                }
                else
                {
                    amountOwed = 0;
                    return amountOwed;
                }
            }
        }

        private double changeDue = 0;
        /// <summary>
        /// the amount of change that the customer needs returned
        /// </summary>
        public double ChangeDue
        {
            get
            {
                if (TotalDue - TotalCash > 0)
                {
                    changeDue = 0;
                    return changeDue;
                }
                else
                {
                    changeDue = TotalCash - TotalDue;
                    return changeDue;
                }
            }
        }
    }
}
