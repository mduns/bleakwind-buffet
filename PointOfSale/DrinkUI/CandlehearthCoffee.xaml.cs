﻿/*Author: Mason Dunsmore
 * Class: CandlehearthCoffee.xaml.cs
 * Purpose: Hanldes User input for this class 
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

namespace PointOfSale.DrinkUI
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public CandlehearthCoffee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the backButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var drink = new Drinks();
            this.Content = drink;
        }
        /// <summary>
        /// event handler for the doneButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var main = new PickType();
            this.Content = main;
        }
    }
}