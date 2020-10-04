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
            var aa = new AretinoAppleJuiceUC();
            aa.DataContext = new AretinoAppleJuice();
            this.Content = aa;
        }
        /// <summary>
        /// Event handler for the candlehearth coffee button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ccButton_Click(object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffeeUC();
            cc.DataContext = new CandlehearthCoffee();
            this.Content = cc;
        }
        /// <summary>
        /// Event handler for the markarth milk button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmButton_Click(object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilkUC();
            mm.DataContext = new MarkarthMilk();
            this.Content = mm;
        }
        /// <summary>
        /// Event handler for the Sailor Soda button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sailorButton_Click(object sender, RoutedEventArgs e)
        {
            var sailor = new SailorSodaUC();
            sailor.DataContext = new SailorSoda();
            this.Content = sailor;
        }
        /// <summary>
        /// Event handler for the warrior water button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wwButton_Click(object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWaterUC();
            ww.DataContext = new WarriorWater();
            this.Content = ww;
        }
        /// <summary>
        /// event handler for the backButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var back = new PickType();
            this.Content = back;
        }
    }
}
