/*Author: Mason Dunsmore
 * Class: Entrees.xaml.cs
 * Purpose: Handles user input for the entrees xaml
 */
using BleakwindBuffet.Data.Entrees;
using PointOfSale.EntreeUI;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Entrees.xaml
    /// </summary>
    public partial class Entrees : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public Entrees()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the Briarheart Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbButton_Click(object sender, RoutedEventArgs e)
        {
            var bbUC = new BriarheartBurgerUC();
            var bb = new BriarheartBurger();
            bbUC.DataContext = bb;
            this.Content = bbUC;
            if(DataContext is Order order)
            {
                order.Add(bb);
            }
        }
        /// <summary>
        /// Event handler for the Double Draugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddButton_Click(object sender, RoutedEventArgs e)
        {
            var ddUC = new DoubleDraugrUC();
            var dd = new DoubleDraugr();
            ddUC.DataContext = dd;
            this.Content = ddUC;
            if(DataContext is Order order)
            {
                order.Add(dd);
            }
        }
        /// <summary>
        /// Event handler for the Garden Orc omelette button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gocButton_Click(object sender, RoutedEventArgs e)
        {
            var goUC = new GardenOrcOmeletteUC();
            var go = new GardenOrcOmelette();
            goUC.DataContext = go;
            this.Content = goUC;
            if(DataContext is Order order)
            {
                order.Add(go);
            }
        }
        /// <summary>
        /// Event handler for the philly poacher button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ppButton_Click(object sender, RoutedEventArgs e)
        {
            var ppUC = new PhillyPoacherUC();
            var pp = new PhillyPoacher();
            ppUC.DataContext = pp;
            this.Content = ppUC;
            if (DataContext is Order order)
            {
                order.Add(pp);
            }
        }
        /// <summary>
        /// Event handler for the smokehouse skeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ssButton_Click(object sender, RoutedEventArgs e)
        {
            var ssUC = new SmokehouseSkeletonUC();
            var ss = new SmokehouseSkeleton();
            ssUC.DataContext = ss;
            this.Content = ssUC;
            if (DataContext is Order order)
            {
                order.Add(ss);
            }
        }
        /// <summary>
        /// Event handler for the thalmor triple button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttButton_Click(object sender, RoutedEventArgs e)
        {
            var ttUC = new ThalmorTripleUC();
            var tt = new ThalmorTriple();
            ttUC.DataContext = tt;
            this.Content = ttUC;
            if (DataContext is Order order)
            {
                order.Add(tt);
            }
        }
        /// <summary>
        /// Event handler for the thugs t bone button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbButton_Click(object sender, RoutedEventArgs e)
        {
            var ttbUC = new ThugsTBoneUC();
            var ttb = new ThugsTBone();
            ttbUC.DataContext = ttb;
            this.Content = ttbUC;
            if (DataContext is Order order)
            {
                order.Add(ttb);
            }
        }
        /// <summary>
        /// Event handler for the backButton
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
            if (parent is ComboUC combo)
            {
                this.Content = new ComboUC();
            }
        }
    }
}
