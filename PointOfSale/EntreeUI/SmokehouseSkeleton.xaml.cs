﻿/*Author: Mason Dunsmore
 * Class: SmokehouseSkeleton.xaml.cs
 * Purpose: Handles user input from the smokehouse skeleton xaml
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

namespace PointOfSale.EntreeUI
{
    /// <summary>
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeletonUC : UserControl
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        public SmokehouseSkeletonUC()
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
            var entree = new Entrees();
            this.Content = entree;
        }
        /// <summary>
        /// event handler for the doneButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var main = new PickType();
            this.Content = main;
        }
    }
}
