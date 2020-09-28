/* Author: Mason Dunsmore
 * Class: VokunSalad.xaml.cs
 * Purpose: Handles any uder interface in the Vokun salad UserControl
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

namespace PointOfSale.SideUI
{
    /// <summary>
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class VokunSalad : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public VokunSalad()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the back button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var side = new Sides();
            this.Content = side;
        }
        /// <summary>
        /// Event handler for the Done button
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
