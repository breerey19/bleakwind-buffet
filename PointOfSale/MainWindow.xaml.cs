using BleakwindBuffet.Data;
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

/*
 * Author: Bree Reynoso
 * Class name: MainWindow.xaml.cs
 * Purpose: MainWindow calls MenuLayout to display built project
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ChildScreen child = new ChildScreen(MenuSections);
        //ParentScreen parent = new ParentScreen();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Order();
        }

    }
}
