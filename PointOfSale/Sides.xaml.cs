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
using BleakwindBuffet.Data;

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
            var dwUC = new DragonbornWaffleFriesUC();
            var dw = new DragonbornWaffleFries();
            dwUC.DataContext = dw;
            this.Content = dwUC;
            if (DataContext is Order order)
            {
                order.Add(dw);
            }
        }
        /// <summary>
        /// Event handler for the fried miraak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmButton_Click(object sender, RoutedEventArgs e)
        {
            var fmUC = new FriedMiraakUC();
            var fm = new FriedMiraak();
            fmUC.DataContext = fm;
            this.Content = fmUC;
            if (DataContext is Order order)
            {
                order.Add(fm);
            }
        }
        /// <summary>
        /// event handler for the mad otar grits button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mogButton_Click(object sender, RoutedEventArgs e)
        {
            var moUC = new MadOtarGritsUC();
            var mo = new MadOtarGrits();
            moUC.DataContext = mo;
            this.Content = moUC;
            if (DataContext is Order order)
            {
                order.Add(mo);
            }
        }
        /// <summary>
        /// event handler for the vokun salad button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vsButton_Click(object sender, RoutedEventArgs e)
        {
            var vsUC = new VokunSaladUC();
            var vs = new VokunSalad();
            vsUC.DataContext = vs;
            this.Content = vsUC;
            if (DataContext is Order order)
            {
                order.Add(vs);
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
            if(parent is ComboUC combo)
            {
                this.Content = new ComboUC();
            }
        }
    }
}
