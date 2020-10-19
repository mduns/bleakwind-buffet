/*Author: Mason Dunsmore
 * Class: OrderComponent.xaml.cs
 * Purpose: Handles input from the Order Component xaml
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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Deletes the selected item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(items.SelectedValue is IOrderItem i)
            {
                if(DataContext is Order order)
                {
                    order.Remove(i);
                }
            }
        }
        /// <summary>
        /// Creates a new order 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main)
            {
                main.menuComponent.Child = new PaymentScreen();
            }
        }
    }
}
