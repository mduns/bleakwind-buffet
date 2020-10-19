/*Author: Mason Dunsmore
 * Class: CashPayment.xaml.cs
 * Purpose: Codebehind and logic handler for the CashPayment xaml
 * 
 * 
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        CashAmount cash = new CashAmount();
        public CashPayment()
        {
            InitializeComponent();
            this.DataContext = cash;
        }
        /// <summary>
        /// event handler if any plus button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if(button.Name == "hundredPlus")
                {
                    cash.HundredAmount++;
                    CheckZero(hundredMinus, hundred);
                    ResetChange();
                    UpdateChange();
                }
                else if(button.Name == "fiftyPlus")
                {
                    cash.FiftyAmount++;
                    CheckZero(fiftyMinus, fifty);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "twentyPlus")
                {
                    cash.TwentyAmount++;
                    CheckZero(twentyMinus, twenty);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "tenPlus")
                {
                    cash.TenAmount++;
                    CheckZero(tenMinus, ten);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fivePlus")
                {
                    cash.FiveAmount++;
                    CheckZero(fiveMinus, five);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "onePlus")
                {
                    cash.OneAmount++;
                    CheckZero(oneMinus, one);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiftyCentPlus")
                {
                    cash.FiftyCentAmount++;
                    CheckZero(fiftyCentMinus, fiftyCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "twentyFiveCentPlus")
                {
                    cash.TwentyFiveCentAmount++;
                    CheckZero(twentyFiveCentMinus, twentyFiveCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "tenCentPlus")
                {
                    cash.TenCentAmount++;
                    CheckZero(tenCentMinus, tenCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiveCentPlus")
                {
                    cash.FiveCentAmount++;
                    CheckZero(fiveCentMinus, fiveCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "oneCentPlus")
                {
                    cash.OneCentAmount++;
                    CheckZero(oneCentMinus, oneCent);
                    ResetChange();
                    UpdateChange();
                }
            }
        }
        /// <summary>
        /// Event handler for any minus button that is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if(button.Name == "hundredMinus")
                {
                    cash.HundredAmount--;
                    CheckZero(button, hundred);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiftyMinus")
                {
                    cash.FiftyAmount--;
                    CheckZero(button, fifty);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "twentyMinus")
                {
                    cash.TwentyAmount--;
                    CheckZero(button, twenty);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "tenMinus")
                {
                    cash.TenAmount--;
                    CheckZero(button, ten);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiveMinus")
                {
                    cash.FiveAmount--;
                    CheckZero(button, five);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "oneMinus")
                {
                    cash.OneAmount--;
                    CheckZero(button, one);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiftyCentMinus")
                {
                    cash.FiftyCentAmount--;
                    CheckZero(button, fiftyCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "twentyFiveCentMinus")
                {
                    cash.TwentyFiveCentAmount--;
                    CheckZero(button, twentyFiveCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "tenCentMinus")
                {
                    cash.TenCentAmount--;
                    CheckZero(button, tenCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "fiveCentMinus")
                {
                    cash.FiveCentAmount--;
                    CheckZero(button, fiveCent);
                    ResetChange();
                    UpdateChange();
                }
                else if (button.Name == "oneCentMinus")
                {
                    cash.OneCentAmount--;
                    CheckZero(button, oneCent);
                    ResetChange();
                    UpdateChange();
                }
            }
        }
        /// <summary>
        /// Checks if the current number in the text box is zero 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        private void CheckZero(Button b, TextBlock t)
        {
            if(t.Text == "0")
            {
                b.IsEnabled = false;
            }
            else
            {
                b.IsEnabled = true;
            }
        }
        /// <summary>
        /// sets the TotalDue to the order total when the UI is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main)
            {
                if (main.DataContext is Order order)
                {
                    cash.TotalDue = order.Total;
                }
            }
        }
        /// <summary>
        /// Processes payment and finalizes the sale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finalize_Click(object sender, RoutedEventArgs e)
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds = cash.HundredAmount - cash.HundredChangeAmount;
            CashDrawer.Fifties = cash.FiftyAmount - cash.FiftyChangeAmount;
            CashDrawer.Twenties = cash.TwentyAmount - cash.TwentyChangeAmount;
            CashDrawer.Fives = cash.FiveAmount - cash.FiveChangeAmount;
            CashDrawer.Ones = cash.OneAmount - cash.OneChangeAmount;
            CashDrawer.HalfDollars = cash.FiftyCentAmount - cash.FiftyCentChangeAmount;
            CashDrawer.Quarters = cash.TwentyFiveCentAmount - cash.TwentyFiveCentChangeAmount;
            CashDrawer.Dimes = cash.TenCentAmount - cash.TenCentChangeAmount;
            CashDrawer.Nickels = cash.FiveCentAmount - cash.FiveCentChangeAmount;
            CashDrawer.Pennies = cash.OneCentAmount - cash.OneCentChangeAmount;

            if(cash.AmountOwed > 0)
            {
                MessageBox.Show("Please pay the rest of the amount owed");
            }
            else
            {
                MessageBox.Show("Sale Finalized");
                DependencyObject parent = this;
                do
                {
                    parent = LogicalTreeHelper.GetParent(parent);
                } while (!(parent is MainWindow) && !(parent is null));
                if (parent is MainWindow main)
                {
                    if(main.DataContext is Order o)
                    {
                        string num = "Order number: " + o.Number;
                        RoundRegister.RecieptPrinter.PrintLine(num);
                        RoundRegister.RecieptPrinter.PrintLine("");
                        DateTime now = DateTime.Now;
                        string time = now.ToString();
                        RoundRegister.RecieptPrinter.PrintLine(time);
                        RoundRegister.RecieptPrinter.PrintLine("");
                        foreach (IOrderItem i in o)
                        {
                            string item = i.ToString();
                            if (item.Length <= 40)
                            {
                                RoundRegister.RecieptPrinter.PrintLine(item);
                            }
                            List<string> instructions = i.SpecialInstructions;
                            foreach (string j in instructions)
                            {
                                if (j.Length < 40)
                                {
                                    RoundRegister.RecieptPrinter.PrintLine("-" + j);
                                }
                            }
                            RoundRegister.RecieptPrinter.PrintLine("");
                        }
                        RoundRegister.RecieptPrinter.PrintLine("");
                        double sub = Math.Round(o.Subtotal, 2);
                        string subtotal = "Subtotal: $" + sub;
                        RoundRegister.RecieptPrinter.PrintLine(subtotal);
                        double tax = Math.Round(o.Tax, 2);
                        string taxes = "Tax: $" + tax;
                        RoundRegister.RecieptPrinter.PrintLine(taxes);
                        double tot = Math.Round(o.Total, 2);
                        string total = "Total: $" + tot;
                        RoundRegister.RecieptPrinter.PrintLine(total);
                        RoundRegister.RecieptPrinter.PrintLine("");
                        RoundRegister.RecieptPrinter.PrintLine("Paid with Cash");
                        RoundRegister.RecieptPrinter.CutTape();
                    }
                    main.DataContext = new Order();
                    main.menuComponent.Child = new PickType();
                }
            }
        }
        /// <summary>
        /// Updates the amount of each type of currency in change is due
        /// </summary>
        private void UpdateChange()
        {
            double change = cash.ChangeDue;
            if(change > 0)
            {
                while (change / 100 >= 1)
                {
                    change -= 100;
                    cash.HundredChangeAmount++;
                }
                while (change / 50 >= 1)
                {
                    change -= 50;
                    cash.FiftyChangeAmount++;
                }
                while (change / 20 >= 1)
                {
                    change -= 20;
                    cash.TwentyChangeAmount++;
                }
                while (change / 10 >= 1)
                {
                    change -= 10;
                    cash.TenChangeAmount++;
                }
                while (change / 5 >= 1)
                {
                    change -= 5;
                    cash.FiveChangeAmount++;
                }
                while (change / 1 >= 1)
                {
                    change -= 1;
                    cash.OneChangeAmount++;
                }
                while (change / .5 >= 1)
                {
                    change -= .5;
                    cash.FiftyCentChangeAmount++;
                }
                while (change / .25 >= 1)
                {
                    change -= .25;
                    cash.TwentyFiveCentChangeAmount++;
                }
                while (change / .10 >= 1)
                {
                    change -= .10;
                    cash.TenCentChangeAmount++;
                }
                while (change / .05 >= 1)
                {
                    change -= .05;
                    cash.FiveCentChangeAmount++;
                }
                while (change / .01 >= 1)
                {
                    change -= .01;
                    cash.OneCentChangeAmount++;
                }
            }
        }
        /// <summary>
        /// Resets the change everytime any money is added or taken away
        /// </summary>
        private void ResetChange()
        {
            cash.HundredChangeAmount = 0;
            cash.FiftyChangeAmount = 0;
            cash.TwentyChangeAmount = 0;
            cash.TenChangeAmount = 0;
            cash.FiveChangeAmount = 0;
            cash.OneChangeAmount = 0;
            cash.FiftyCentChangeAmount = 0;
            cash.TwentyFiveCentChangeAmount = 0;
            cash.TenCentChangeAmount = 0;
            cash.FiveCentChangeAmount = 0;
            cash.OneCentChangeAmount = 0;
        }
        /// <summary>
        /// Event handler for the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main)
            {
                main.menuComponent.Child = new PickType();
            }
        }
    }
}
