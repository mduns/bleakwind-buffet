/*Author: Mason Dunsmore
 * Class: ComboUC.xaml.cs
 * Purpose: Codebehind and logic handler for the ComboUC xaml
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboUC.xaml
    /// </summary>
    public partial class ComboUC : UserControl
    {
        public ComboUC()
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
        /// <summary>
        /// Event handler for the Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main)
            {
                if(main.DataContext is Order order)
                {
                    if(DataContext is Combo combo)
                    {
                        order.Add(combo);
                    }
                }
                main.menuComponent.Child = new PickType();
            }
        }
        /// <summary>
        /// Updates the IsEnabled function of the add button everytime a new comboUC screen is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                if (combo.Entree == null || combo.Side == null || combo.Drink == null)
                {
                    addButton.IsEnabled = false;
                }
                else
                {
                    addButton.IsEnabled = true;
                }
            }
        }
    }
}
