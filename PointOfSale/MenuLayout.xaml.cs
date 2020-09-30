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
 * Class name: MenuLayout.xaml.cs
 * Purpose: Displays the OrderComponent and MenuSections together to be displayed upon building
 */


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuLayout.xaml
    /// </summary>
    public partial class MenuLayout : UserControl
    {
        /// <summary>
        /// Set MenuSections variable as children
        /// </summary>
        public MenuLayout()
        {
            InitializeComponent();
            menuSectionsBorder.Child = new MenuSections(this);
        }

        /// <summary>
        /// Allows screens to be swapped when call, 
        /// used to display customization screen and display menuSections
        /// </summary>
        /// <param name="fe">framework to be a child and swapped between</param>
        public void SwapScreen(FrameworkElement fe)
        {
            menuSectionsBorder.Child = fe;
        }
    }
}
