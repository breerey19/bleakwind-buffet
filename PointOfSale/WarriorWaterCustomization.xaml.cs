using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for WarriorWaterCustomization.xaml
    /// </summary>
    public partial class WarriorWaterCustomization : UserControl
    {
        private MenuLayout ml;
        private MenuSections ms;
        public WarriorWaterCustomization(MenuSections m, MenuLayout l)
        {
            InitializeComponent();
            //DataContext = new WarriorWater();
            ms = m;
            ml = l;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            ml.SwapScreen(ms);
        }

    }
}
