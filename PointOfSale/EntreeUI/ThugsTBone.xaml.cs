/*Author: Mason Dunsmore
 * Class: ThugsTBone.xaml.cs
 * Purpose: Handles user input from the ThugsTBone xaml
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.EntreeUI
{
    /// <summary>
    /// Interaction logic for ThugsTBone.xaml
    /// </summary>
    public partial class ThugsTBoneUC : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public ThugsTBoneUC()
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
                    if (this.DataContext is ThugsTBone item)
                    {
                        combo.Entree = item;
                    }
                    this.DataContext = combo;
                }
            }
        }
    }
}
