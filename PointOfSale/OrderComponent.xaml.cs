using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Author: Bree Reynoso
 * Class name: OrderCompenent.xaml.cs
 * Purpose: The reciept part of the menu screen 
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// The order /reciept screen to be shown when built
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }

        //Size does not change string name display or update any prices
        //Need to figure out a way to best put a remove option for each item on order


        ///void DisplayOrderItems(object sender, RoutedEventArgs e)
        ///{
        ///}
    }
}
