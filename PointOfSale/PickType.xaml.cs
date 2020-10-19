/*Author: Mason Dunsmore
 * Class: PickType.xaml.cs
 * Purpose: Handles user input for the Pick type xaml
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PickType.xaml
    /// </summary>
    public partial class PickType : UserControl
    {
        /// <summary>
        /// Initializese the class
        /// </summary>
        public PickType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the entree button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entreeButton_Click(object sender, RoutedEventArgs e)
        {
            var entrees = new Entrees();
            this.Content = entrees;
        }
        /// <summary>
        /// Event handler for the drink button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drinkButton_Click(object sender, RoutedEventArgs e)
        {
            var drinks = new Drinks();
            this.Content = drinks;
        }
        /// <summary>
        /// Event handler for the side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideButton_Click(object sender, RoutedEventArgs e)
        {
            var sides = new Sides();
            this.Content = sides;
        }

        private void comboButton_Click(object sender, RoutedEventArgs e)
        {
            var combo = new ComboUC();
            this.Content = combo;
            this.DataContext = new Combo();
        }
    }
}
