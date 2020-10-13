/*Author: Mason Dunsmore
 * Class: SailorSoda.xaml.cs
 * Purpose: Handles user input for markarth milk xaml
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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

namespace PointOfSale.DrinkUI
{
    /// <summary>
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSodaUC : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public SailorSodaUC()
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
        /// <summary>
        /// BackCode to set the Size enum Property depending on the radio button that was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void size_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton r)
            {
                if (r.Name == "small")
                {
                    ((Drink)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (r.Name == "medium")
                {
                    ((Drink)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (r.Name == "large")
                {
                    ((Drink)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
        /// <summary>
        /// BackCode to set the SodaFlavor enum Property depending on the radio button that was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flavor_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton r)
            {
                if (r.Name == "blackberry")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                }
                if (r.Name == "cherry")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                }
                if (r.Name == "grapefruit")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                }
                if (r.Name == "lemon")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                }
                if (r.Name == "peach")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                }
                if (r.Name == "watermelon")
                {
                    ((Drink)DataContext).Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
                }
            }
        }
    }
}
