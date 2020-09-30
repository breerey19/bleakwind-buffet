using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
 * Class name: MenuSections.xaml.cs
 * Purpose: Used to access all buttons of menu items and proper executions, 
 * calls customization screens for clicked buttons
 */


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSections.xaml
    /// </summary>
    public partial class MenuSections : UserControl
    {
        List<OrderComponent> order = new List<OrderComponent>();
        private MenuLayout menuLayout;

        public MenuSections(MenuLayout ml)
        {
            InitializeComponent();
            InitializeButtons();
            menuLayout = ml;
        }

        /// <summary>
        /// Checks which button(s) are pushed, displays customization options 
        /// and later will send the added item to a list of ordered items to display on receipt
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void BriarheartBurgerClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new BriarheartBurgerCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void DoubleDraugrClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new DoubleDraugrCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void ThalmorTripleClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new ThalmorTripleCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void PhillyPoacherClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new PhillyPoacherCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void GardenOrcOmeletteClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new GardenOrcOmeletteCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void SmokehouseSkeletonClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new SmokehouseSkeletonCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void VokunSaladClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new VokunSaladCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void DragonbornWaffleFriesClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new DragonbornWaffleFriesCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void MadOtarGritsClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new MadOtarGritsCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void FriedMiraakClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new FriedMiraakCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void SailorSodaClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new SailorSodaCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void AretinoAppleJuiceClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new AretinoAppleJuiceCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void MarkarthMilkClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new MarkarthMilkCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void CandlehearthCoffeeClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new CandlehearthCoffeeCustomization(this, menuLayout));
        }

        /// <summary>
        /// When the button is pushed it displays the customization screen
        /// </summary>
        /// <param name="sender">the object affected</param>
        /// <param name="e">the event taking place</param>
        void WarriorWaterClicked(object sender, RoutedEventArgs e)
        {
            menuLayout.SwapScreen(new WarriorWaterCustomization(this, menuLayout));
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
        }
    }
}
