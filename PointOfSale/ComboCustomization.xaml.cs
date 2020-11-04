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
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : UserControl
    {
        /// <summary>
        /// Sets global variables to constructor properties and initializes components
        /// </summary>
        /// <param name="m">MenuSection return to after 'done' is clicked</param>
        /// <param name="l">MenuLayout to place customization screen</param>
        public ComboCustomization(MenuSections m, MenuLayout l)
        {
            InitializeComponent();
            InitializeButtons();
            
            //DataContext = new Combo();
            ms = m;
            ml = l;
        }
        /// <summary>
        /// global private MenuLayout and MenuSection variables
        /// </summary>
        private MenuLayout ml;
        private MenuSections ms;

        //Maybe set all other buttons to false for each type once option chosen


        /// <summary>
        /// Closes customization screen and returns to menu sections screen after 'done' is pressed
        /// </summary>
        /// <param name="sender">the object that is active</param>
        /// <param name="e">the event taking place with the object</param>
        private void doneButton_Click(object sender, EventArgs e)
        {
            ml.SwapScreen(ms);
        }

        /// <summary>
        /// Makes sure all buttons for menu items are enabled for one to be clicked
        /// </summary>
        void InitializeButtons()
        {
            BriarheartBurgerButton.IsEnabled = true;
            DoubleDraugrButton.IsEnabled = true;
            ThalmorTripleButton.IsEnabled = true;
            GardenOrcOmeletteButton.IsEnabled = true;
            PhillyPoacherButton.IsEnabled = true;
            SmokehouseSkeletonButton.IsEnabled = true;
            ThugsTBoneButton.IsEnabled = true;

            AretinoAppleJuiceButton.IsEnabled = true;
            CandlehearthCoffeeButton.IsEnabled = true;
            SailorSodaButton.IsEnabled = true;
            MarkarthMilkButton.IsEnabled = true;
            WarriorWaterButton.IsEnabled = true;

            DragonbornWaffleFriesButton.IsEnabled = true;
            FriedMiraakButton.IsEnabled = true;
            MadOtarGritsButton.IsEnabled = true;
            VokunSaladButton.IsEnabled = true;

            //ComboButton.IsEnabled = true;
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void BriarheartBurgerClicked(object sender, RoutedEventArgs e)
        {
            //menuLayout.DataContext = new BriarheartBurger();
            //BriarheartBurgerCustomization bbc = new BriarheartBurgerCustomization(this, menuLayout);
            //var bb = new BriarheartBurger();
            //bbc.DataContext = bb;
            //var order = (Order)DataContext;
            //order.Add(bb);
            //menuLayout.SwapScreen(bbc);


            //combo.Entree = bb;

        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void DoubleDraugrClicked(object sender, RoutedEventArgs e)
        {
            //DoubleDraugrCustomization ddc = new DoubleDraugrCustomization(this, menuLayout);
            //var dd = new DoubleDraugr();
            //ddc.DataContext = dd;
            //var order = (Order)DataContext;
            //order.Add(dd);
            //menuLayout.SwapScreen(ddc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void ThalmorTripleClicked(object sender, RoutedEventArgs e)
        {
            //ThalmorTripleCustomization ttc = new ThalmorTripleCustomization(this, menuLayout);
            //var tt = new ThalmorTriple();
            //ttc.DataContext = tt;
            //var order = (Order)DataContext;
            //order.Add(tt);
            //menuLayout.SwapScreen(ttc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void PhillyPoacherClicked(object sender, RoutedEventArgs e)
        {
            //PhillyPoacherCustomization ppc = new PhillyPoacherCustomization(this, menuLayout);
            //var pp = new PhillyPoacher();
            //ppc.DataContext = pp;
            //var order = (Order)DataContext;
            //order.Add(pp);
            //menuLayout.SwapScreen(ppc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void GardenOrcOmeletteClicked(object sender, RoutedEventArgs e)
        {
            //GardenOrcOmeletteCustomization gooc = new GardenOrcOmeletteCustomization(this, menuLayout);
            //var goo = new GardenOrcOmelette();
            //gooc.DataContext = goo;
            //var order = (Order)DataContext;
            //order.Add(goo);
            //menuLayout.SwapScreen(gooc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void SmokehouseSkeletonClicked(object sender, RoutedEventArgs e)
        {
            //SmokehouseSkeletonCustomization ssc = new SmokehouseSkeletonCustomization(this, menuLayout);
            //var ss = new SmokehouseSkeleton();
            //ssc.DataContext = ss;
            //var order = (Order)DataContext;
            //order.Add(ss);
            //menuLayout.SwapScreen(ssc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void VokunSaladClicked(object sender, RoutedEventArgs e)
        {
            //VokunSaladCustomization vsc = new VokunSaladCustomization(this, menuLayout);
            //var vs = new VokunSalad();
            //vsc.DataContext = vs;
            //var order = (Order)DataContext;
            //order.Add(vs);
            //menuLayout.SwapScreen(vsc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void DragonbornWaffleFriesClicked(object sender, RoutedEventArgs e)
        {
            //DragonbornWaffleFriesCustomization dwfc = new DragonbornWaffleFriesCustomization(this, menuLayout);
            //var dwf = new DragonbornWaffleFries();
            //dwfc.DataContext = dwf;
            //var order = (Order)DataContext;
            //order.Add(dwf);
            //menuLayout.SwapScreen(dwfc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void MadOtarGritsClicked(object sender, RoutedEventArgs e)
        {
            //MadOtarGritsCustomization mogc = new MadOtarGritsCustomization(this, menuLayout);
            //var mog = new MadOtarGrits();
            //mogc.DataContext = mog;
            //var order = (Order)DataContext;
            //order.Add(mog);
            //menuLayout.SwapScreen(mogc);

        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void FriedMiraakClicked(object sender, RoutedEventArgs e)
        {
            //FriedMiraakCustomization fmc = new FriedMiraakCustomization(this, menuLayout);
            //var fm = new FriedMiraak();
            //fmc.DataContext = fm;
            //var order = (Order)DataContext;
            //order.Add(fm);
            //menuLayout.SwapScreen(fmc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void SailorSodaClicked(object sender, RoutedEventArgs e)
        {
            //SailorSodaCustomization ssc = new SailorSodaCustomization(this, menuLayout);
            //var ss = new SailorSoda();
            //ssc.DataContext = ss;
            //var order = (Order)DataContext;
            //order.Add(ss);
            //menuLayout.SwapScreen(ssc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void AretinoAppleJuiceClicked(object sender, RoutedEventArgs e)
        {
            //AretinoAppleJuiceCustomization ajc = new AretinoAppleJuiceCustomization(this, menuLayout);
            //var aj = new AretinoAppleJuice();
            //ajc.DataContext = aj;
            //var order = (Order)DataContext;
            //order.Add(aj);
            //menuLayout.SwapScreen(ajc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void MarkarthMilkClicked(object sender, RoutedEventArgs e)
        {
            //MarkarthMilkCustomization mmc = new MarkarthMilkCustomization(this, menuLayout);
            //var mm = new AretinoAppleJuice();
            //mmc.DataContext = mm;
            //var order = (Order)DataContext;
            //order.Add(mm);
            //menuLayout.SwapScreen(mmc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void CandlehearthCoffeeClicked(object sender, RoutedEventArgs e)
        {
            //CandlehearthCoffeeCustomization ccc = new CandlehearthCoffeeCustomization(this, menuLayout);
            //var cc = new CandlehearthCoffee();
            //ccc.DataContext = cc;
            //var order = (Order)DataContext;
            //order.Add(cc);
            //menuLayout.SwapScreen(ccc);
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void WarriorWaterClicked(object sender, RoutedEventArgs e)
        {
            //WarriorWaterCustomization wwc = new WarriorWaterCustomization(this, menuLayout);
            //var ww = new WarriorWater();
            //wwc.DataContext = ww;
            //var order = (Order)DataContext;
            //order.Add(ww);
            //menuLayout.SwapScreen(wwc);
        }
    }
}
