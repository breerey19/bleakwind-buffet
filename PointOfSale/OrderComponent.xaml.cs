using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        private Order order = new Order();
        /// <summary>
        /// The order /reciept screen to be shown when built
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            var order = (Order)DataContext;
            //var order = new Order();
        }

        private void RemoveFromOrder_Click(object sender, RoutedEventArgs e)
        {
            //if (DataContext is Order order)
            //{
               //var itemBeingRemoved = (IOrderItem)order.SelectedItem;
                //order.Remove(itemBeingRemoved);
                //order.Remove((IOrderItem) ReceiptListBox.SelectedItem);
                //CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, items));
            //}
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //open payment screen
            //update order number for next order

        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //Size does not change string name display or update any prices
        //Need to figure out a way to best put a remove option for each item on order


        ///void DisplayOrderItems(object sender, RoutedEventArgs e)
        ///{
        ///}
    }
}
