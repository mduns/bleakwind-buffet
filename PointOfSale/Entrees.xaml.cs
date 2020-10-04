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
            var bb = new BriarheartBurgerUC();
            bb.DataContext = new BriarheartBurger();
            this.Content = bb;
        }
        /// <summary>
        /// Event handler for the Double Draugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddButton_Click(object sender, RoutedEventArgs e)
        {
            var dd = new DoubleDraugrUC();
            dd.DataContext = new DoubleDraugr();
            this.Content = dd;
        }
        /// <summary>
        /// Event handler for the Garden Orc omelette button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gocButton_Click(object sender, RoutedEventArgs e)
        {
            var goc = new GardenOrcOmeletteUC();
            goc.DataContext = new GardenOrcOmelette();
            this.Content = goc;
        }
        /// <summary>
        /// Event handler for the philly poacher button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ppButton_Click(object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacherUC();
            pp.DataContext = new PhillyPoacher();
            this.Content = pp;
        }
        /// <summary>
        /// Event handler for the smokehouse skeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ssButton_Click(object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeletonUC();
            ss.DataContext = new SmokehouseSkeleton();
            this.Content = ss;
        }
        /// <summary>
        /// Event handler for the thalmor triple button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttButton_Click(object sender, RoutedEventArgs e)
        {
            var tt = new ThalmorTripleUC();
            tt.DataContext = new ThalmorTriple();
            this.Content = tt;
        }
        /// <summary>
        /// Event handler for the thugs t bone button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbButton_Click(object sender, RoutedEventArgs e)
        {
            var ttb = new ThugsTBoneUC();
            ttb.DataContext = new ThugsTBone();
            this.Content = ttb;
        }
        /// <summary>
        /// Event handler for the backButton
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
