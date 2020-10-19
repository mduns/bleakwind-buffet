/*Author: Mason Dunsmore
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace PointOfSale.DrinkUI
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffeeUC : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public CandlehearthCoffeeUC()
        {
            InitializeComponent();
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
            } while ((!(parent is MainWindow) && !(parent is null)) && !(parent is ComboUC));
            if (parent is MainWindow main)
            {
                main.menuComponent.Child = new PickType();
            }
            else if (parent is ComboUC c)
            {
                this.Content = new ComboUC();
                if (c.DataContext is Combo combo)
                {
                    if (this.DataContext is CandlehearthCoffee item)
                    {
                        combo.Drink = item;
                    }
                    this.DataContext = combo;
                }
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
    }
}
