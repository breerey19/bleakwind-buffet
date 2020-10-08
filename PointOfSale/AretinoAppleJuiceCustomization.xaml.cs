using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

///using BleakwindBuffet.Data.Enums;
///using BleakwindBuffet.Data.Drinks;

/*
 * Author: Bree Reynoso
 * Class name: AretinoAppleJuiceCustomization.xaml.cs
 * Purpose: Displays customization screen for Aretino Apple Juice Order
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl //INotifyPropertyChanged //IOrderItem 
    {
        /// <summary>
        /// global private MenuLayout and MenuSection variables
        /// </summary>
        private MenuLayout ml;
        private MenuSections ms;


        /// <summary>
        /// Sets global variables to constructor properties and initializes components
        /// </summary>
        /// <param name="m">MenuSection return to after 'done' is clicked</param>
        /// <param name="l">MenuLayout to place customization screen</param>
        public AretinoAppleJuiceCustomization(MenuSections m, MenuLayout l)
        {
            InitializeComponent();
            DataContext = new AretinoAppleJuice();       
            ms = m;
            ml = l;
        }

        //private double price;


        public void AddItemToReciept()
        {
            
        }

        /// <summary>
        /// Closes customization screen and returns to menu sections screen after 'done' is pressed
        /// </summary>
        /// <param name="sender">the object that is active</param>
        /// <param name="e">the event taking place with the object</param>
        private void doneButton_Click(object sender, EventArgs e)
        {
            ml.SwapScreen(ms);
        }



        //public bool ice_Checked(object sender, EventArgs e)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));

        //}

        //private Size size = Size.Small;

        //public Size size_Checked(object sender, EventArgs e)
        //{
        //    foreach(ComboBoxItem sizeOption in sizeComboBox)
        //    {
        //        if(smallSize.IsSelected == true)
        //        {
        //            size = Size.Small;
        //       }
        //        else if(mediumSize.IsSelected == true)
        //        {
        //            size = Size.Medium;
        //       }
        //       else(largeSize.IsSelected == true)
        //        {
        //            size = Size.Large;
        //        }
        //    }
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
        //}








        /// <summary>
        /// Updates the items in the ToDoLists and calls the CollectionItemChangedListener to update counts
        /// </summary>
        /// <param name="sender">object affected</param>
        /// <param name="e">event of property of object changing</param>
        ///
        //void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    OnPropertyChanged(new PropertyChangedEventArgs("CompleteCount"));
        //    OnPropertyChanged(new PropertyChangedEventArgs("IncompleteCount"));
        //    switch (e.Action)
        //    {
        //        case NotifyCollectionChangedAction.Add:
        //            foreach (ToDoItem item in e.NewItems)
        //           {
        //                item.PropertyChanged += CollectionItemChangedListener;
        //            }
        //            break;
        //        case NotifyCollectionChangedAction.Remove:
        //            foreach (ToDoItem item in e.OldItems)
        //            {
        //                item.PropertyChanged += CollectionItemChangedListener;
        //            }
        //            break;
        //        case NotifyCollectionChangedAction.Reset:
        //            throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
        //    }
        //}

        /// <summary>
        /// Changes the complete and incomplete counts when an task is checked off on the ToDoList
        /// </summary>
        /// <param name="sender">object affected</param>
        /// <param name="e">event of property of object changing</param>
        //void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        //{
        //if (e.PropertyName == "Complete")
        //{
        //    OnPropertyChanged(new PropertyChangedEventArgs("CompleteCount"));
        //    OnPropertyChanged(new PropertyChangedEventArgs("IncompleteCount"));
        //}
        //}


    }
}
