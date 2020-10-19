/*Author: Mason Dunsmore
 * Class: Drinks.xaml.cs
 * Purpose: Handles the user input for the drinks xaml
 */
using PointOfSale.DrinkUI;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public Drinks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the AretinoApple Juice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aaButton_Click(object sender, RoutedEventArgs e)
        {
            var aaUC = new AretinoAppleJuiceUC();
            var aa = new AretinoAppleJuice();
            aaUC.DataContext = aa;
            this.Content = aaUC;
            if (DataContext is Order order)
            {
                order.Add(aa);
            }
        }
        /// <summary>
        /// Event handler for the candlehearth coffee button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ccButton_Click(object sender, RoutedEventArgs e)
        {
            var ccUC = new CandlehearthCoffeeUC();
            var cc = new CandlehearthCoffee();
            ccUC.DataContext = cc;
            this.Content = ccUC;
            if (DataContext is Order order)
            {
                order.Add(cc);
            }
        }
        /// <summary>
        /// Event handler for the markarth milk button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmButton_Click(object sender, RoutedEventArgs e)
        {
            var mmUC = new MarkarthMilkUC();
            var mm = new MarkarthMilk();
            mmUC.DataContext = mm;
            this.Content = mmUC;
            if (DataContext is Order order)
            {
                order.Add(mm);
            }
        }
        /// <summary>
        /// Event handler for the Sailor Soda button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sailorButton_Click(object sender, RoutedEventArgs e)
        {
            var ssUC = new SailorSodaUC();
            var ss = new SailorSoda();
            ssUC.DataContext = ss;
            this.Content = ssUC;
            if (DataContext is Order order)
            {
                order.Add(ss);
            }
        }
        /// <summary>
        /// Event handler for the warrior water button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wwButton_Click(object sender, RoutedEventArgs e)
        {
            var wwUC = new WarriorWaterUC();
            var ww = new WarriorWater();
            wwUC.DataContext = ww;
            this.Content = wwUC;
            if (DataContext is Order order)
            {
                order.Add(ww);
            }

        }
        /// <summary>
        /// event handler for the backButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null) && !(parent is ComboUC));
            if (parent is MainWindow main)
            {
                main.menuComponent.Child = new PickType();
            }
            if (parent is ComboUC combo)
            {
                this.Content = new ComboUC();
            }
        }
    }
}
