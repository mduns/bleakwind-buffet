/*Author: Mason Dunsmore
 * Class: CurrencyControl.xaml.cs
 * Purpose: Never used, but tried to figure out the CurrencyControl
 * 
 * 
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CashPayment),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CashPayment),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CashPayment),
            new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsRender));

        public CurrencyControl()
        {
            InitializeComponent();
        }

        public int CustomerQuantity
        {
            get { return (int)GetValue(CustomerQuantityProperty); }
            set { SetValue(CustomerQuantityProperty, value); }
        }

        public int ChangeQuantity
        {
            get { return (int)GetValue(ChangeQuantityProperty); }
            set { SetValue(ChangeQuantityProperty, value); }
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if(button.Name == "plus")
                {
                    CustomerQuantity++;
                }
                else if(button.Name == "minus")
                {
                    ChangeQuantity--;
                }
            }
        }
    }
}
