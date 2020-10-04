/*Author: Mason Dunsmore
 * Class: Sides.xaml.cs
 * Purpose: handles user input for the sides xaml
 */
using PointOfSale.SideUI;
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Sides.xaml
    /// </summary>
    public partial class Sides : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public Sides()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the dragonborn waffle fries button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dwfButton_Click(object sender, RoutedEventArgs e)
        {
            var dwf = new DragonbornWaffleFriesUC();
            dwf.DataContext = new DragonbornWaffleFries();
            this.Content = dwf;
        }
        /// <summary>
        /// Event handler for the fried miraak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmButton_Click(object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraakUC();
            fm.DataContext = new FriedMiraak();
            this.Content = fm;
        }
        /// <summary>
        /// event handler for the mad otar grits button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mogButton_Click(object sender, RoutedEventArgs e)
        {
            var mog = new MadOtarGritsUC();
            mog.DataContext = new MadOtarGrits();
            this.Content = mog;
        }
        /// <summary>
        /// event handler for the vokun salad button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vsButton_Click(object sender, RoutedEventArgs e)
        {
            var vs = new VokunSaladUC();
            vs.DataContext = new VokunSalad();
            this.Content = vs;
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
