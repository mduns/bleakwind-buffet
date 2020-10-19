/*Author: Mason Dunsmore
 * Class: PaymentScreen.xaml.cs
 * Purpose: Codebehind and logic handler for the PaymentScreen xaml
 * 
 * 
 */
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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentScreen.xaml
    /// </summary>
    public partial class PaymentScreen : UserControl
    {
        public PaymentScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handler when cash or card buttons are clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentClick(object sender, RoutedEventArgs e)
        {
            double total = 0;
            if(DataContext is Order order)
            {
                total = order.Total;
                CardTransactionResult result = CardReader.RunCard(total);
                if(result == CardTransactionResult.Approved)
                {
                    printReceipt(order);
                    RoundRegister.RecieptPrinter.CutTape();
                    MessageBox.Show("Sale Approved");
                    DependencyObject parent = this;
                    do
                    {
                        parent = LogicalTreeHelper.GetParent(parent);
                    } while (!(parent is MainWindow) && !(parent is null));
                    if (parent is MainWindow main)
                    {
                        main.DataContext = new Order();
                        main.menuComponent.Child = new PickType();
                    }
                }
                else
                {
                    MessageBox.Show("Card Declined");
                }
            }
        }
        /// <summary>
        /// Eventhandler if the cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashClick(object sender, RoutedEventArgs e)
        {
            var cashPay = new CashPayment();
            this.Content = cashPay;
        }
        /// <summary>
        /// Handles and prints the receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="o"></param>
        private void printReceipt(Order o)
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
                if(item.Length <= 40)
                {
                    RoundRegister.RecieptPrinter.PrintLine(item);
                }
                List<string> instructions = i.SpecialInstructions;
                foreach(string j in instructions)
                {
                    if(j.Length < 40)
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
            RoundRegister.RecieptPrinter.PrintLine("Paid with Card");
        }
        /// <summary>
        /// event handler when back button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
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
