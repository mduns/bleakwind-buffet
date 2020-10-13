/*Author: Mason Dunsmore
 * Class: DragonbornWaffleFries.xaml.cs
 * Purpose: Handles user input for the dragonborn waffle fries xaml
 */
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesUC : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public DragonbornWaffleFriesUC()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the doneButton
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
                    ((Side)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (r.Name == "medium")
                {
                    ((Side)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (r.Name == "large")
                {
                    ((Side)DataContext).Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
    }
}
