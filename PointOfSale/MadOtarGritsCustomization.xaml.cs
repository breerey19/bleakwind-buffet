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
 * Class name: MadOtarGritsCustomization.xaml.cs
 * Purpose: Displays customization screen for Mad Otar Grits Order
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MadOtarGritsCustomization.xaml
    /// </summary>
    public partial class MadOtarGritsCustomization : UserControl
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
        public MadOtarGritsCustomization(MenuSections m, MenuLayout l)
        {
            InitializeComponent();
            ms = m;
            ml = l;
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

    }
}
