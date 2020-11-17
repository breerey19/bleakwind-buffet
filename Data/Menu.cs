/*
 * Author: Bree Reynoso
 * Class name: Menu.cs
 * Purpose: Creates a menu class for all menu items
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using System.Dynamic;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Lists all menun item options with instances
    /// </summary>
    public static class Menu 
    {
        /// <summary>
        /// which returns an IEnumerable<IOrderItem> containing an instance of all available entrees offered by Bleakwind Buffet
        /// </summary>
        /// <returns>
        /// List of IOrderItem Entree instances
        /// </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            entrees.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            entrees.Add(dd);
            GardenOrcOmelette goo = new GardenOrcOmelette();
            entrees.Add(goo);
            PhillyPoacher pp = new PhillyPoacher();
            entrees.Add(pp);
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            entrees.Add(ss);
            ThalmorTriple tt = new ThalmorTriple();
            entrees.Add(tt);
            ThugsT_Bone tb = new ThugsT_Bone();
            entrees.Add(tb);
            return entrees;
        }


        /// <summary>
        /// Sides() which returns an IEnumerable<IOrderItem> containing an instance of all available sides offered by Bleakwind Buffet. 
        /// As each side has 3 different sizes, this collection should contain a small, medium, and large instance of each.
        /// </summary>
        /// <returns>
        /// List of IOrderItem Side instances
        /// </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries small_dwf = new DragonbornWaffleFries();
            small_dwf.Size = Size.Small;
            sides.Add(small_dwf);
            DragonbornWaffleFries medium_dwf = new DragonbornWaffleFries();
            medium_dwf.Size = Size.Medium;
            sides.Add(medium_dwf);
            DragonbornWaffleFries large_dwf = new DragonbornWaffleFries();
            large_dwf.Size = Size.Large;
            sides.Add(large_dwf);

            FriedMiraak small_fm = new FriedMiraak();
            small_fm.Size = Size.Small;
            sides.Add(small_fm);
            FriedMiraak medium_fm = new FriedMiraak();
            medium_fm.Size = Size.Medium;
            sides.Add(medium_fm);
            FriedMiraak large_fm = new FriedMiraak();
            large_fm.Size = Size.Large;
            sides.Add(large_fm);

            MadOtarGrits small_mog = new MadOtarGrits();
            small_mog.Size = Size.Small;
            sides.Add(small_mog);
            MadOtarGrits medium_mog = new MadOtarGrits();
            medium_mog.Size = Size.Medium;
            sides.Add(medium_mog);
            MadOtarGrits large_mog = new MadOtarGrits();
            large_mog.Size = Size.Large;
            sides.Add(large_mog);

            VokunSalad small_vs = new VokunSalad();
            small_vs.Size = Size.Small;
            sides.Add(small_vs);
            VokunSalad medium_vs = new VokunSalad();
            medium_vs.Size = Size.Medium;
            sides.Add(medium_vs);
            VokunSalad large_vs = new VokunSalad();
            large_vs.Size = Size.Large;
            sides.Add(large_vs);

            return sides;
        }


        /// <summary>
        /// Drinks() which returns an IEnumerable<IOrderItem> containing all available drinks offered by BleakwindBuffet.
        /// As each drink has 3 different sizes, this collection should contain a small, medium, and large instance of each.
        /// Similarly, it should contain three of each flavor of SailorSoda: one large, one medium, and one small.
        /// </summary>
        /// <returns>
        /// List of IOrderItem Drink instances
        /// </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice small_aj = new AretinoAppleJuice();
            small_aj.Size = Size.Small;
            drinks.Add(small_aj);
            AretinoAppleJuice medium_aj = new AretinoAppleJuice();
            medium_aj.Size = Size.Medium;
            drinks.Add(medium_aj);
            AretinoAppleJuice large_aj = new AretinoAppleJuice();
            large_aj.Size = Size.Large;
            drinks.Add(large_aj);

            CandlehearthCoffee small_cc = new CandlehearthCoffee();
            small_cc.Size = Size.Small;
            drinks.Add(small_cc);
            CandlehearthCoffee medium_cc = new CandlehearthCoffee();
            medium_cc.Size = Size.Medium;
            drinks.Add(medium_cc);
            CandlehearthCoffee large_cc = new CandlehearthCoffee();
            large_cc.Size = Size.Large;
            drinks.Add(large_cc);

            CandlehearthCoffee small_decaf_cc = new CandlehearthCoffee();
            small_decaf_cc.Size = Size.Small;
            small_decaf_cc.Decaf = true;
            drinks.Add(small_decaf_cc);
            CandlehearthCoffee medium_decaf_cc = new CandlehearthCoffee();
            medium_decaf_cc.Size = Size.Medium;
            medium_decaf_cc.Decaf = true;
            drinks.Add(medium_decaf_cc);
            CandlehearthCoffee large_decaf_cc = new CandlehearthCoffee();
            large_decaf_cc.Size = Size.Large;
            large_decaf_cc.Decaf = true;
            drinks.Add(large_decaf_cc);

            MarkarthMilk small_mm = new MarkarthMilk();
            small_mm.Size = Size.Small;
            drinks.Add(small_mm);
            MarkarthMilk medium_mm = new MarkarthMilk();
            medium_mm.Size = Size.Medium;
            drinks.Add(medium_mm);
            MarkarthMilk large_mm = new MarkarthMilk();
            large_mm.Size = Size.Large;
            drinks.Add(large_mm);

            SailorSoda small_cherry_ss = new SailorSoda();
            small_cherry_ss.Size = Size.Small;
            small_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            drinks.Add(small_cherry_ss);
            SailorSoda small_blackberry_ss = new SailorSoda();
            small_blackberry_ss.Size = Size.Small;
            small_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            drinks.Add(small_blackberry_ss);
            SailorSoda small_grapefruit_ss = new SailorSoda();
            small_grapefruit_ss.Size = Size.Small;
            small_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            drinks.Add(small_grapefruit_ss);
            SailorSoda small_lemon_ss = new SailorSoda();
            small_lemon_ss.Size = Size.Small;
            small_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            drinks.Add(small_lemon_ss);
            SailorSoda small_peach_ss = new SailorSoda();
            small_peach_ss.Size = Size.Small;
            small_peach_ss.SodaFlavor = SodaFlavor.Peach;
            drinks.Add(small_peach_ss);
            SailorSoda small_watermelon_ss = new SailorSoda();
            small_watermelon_ss.Size = Size.Small;
            small_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            drinks.Add(small_watermelon_ss);
            SailorSoda medium_cherry_ss = new SailorSoda();
            medium_cherry_ss.Size = Size.Medium;
            medium_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            drinks.Add(medium_cherry_ss);
            SailorSoda medium_blackberry_ss = new SailorSoda();
            medium_blackberry_ss.Size = Size.Medium;
            medium_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            drinks.Add(medium_blackberry_ss);
            SailorSoda medium_grapefruit_ss = new SailorSoda();
            medium_grapefruit_ss.Size = Size.Medium;
            medium_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            drinks.Add(medium_grapefruit_ss);
            SailorSoda medium_lemon_ss = new SailorSoda();
            medium_lemon_ss.Size = Size.Medium;
            medium_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            drinks.Add(medium_lemon_ss);
            SailorSoda medium_peach_ss = new SailorSoda();
            medium_peach_ss.Size = Size.Medium;
            medium_peach_ss.SodaFlavor = SodaFlavor.Peach;
            drinks.Add(medium_peach_ss);
            SailorSoda medium_watermelon_ss = new SailorSoda();
            medium_watermelon_ss.Size = Size.Medium;
            medium_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            drinks.Add(medium_watermelon_ss);

            SailorSoda large_cherry_ss = new SailorSoda();
            large_cherry_ss.Size = Size.Large;
            large_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            drinks.Add(large_cherry_ss);
            SailorSoda large_blackberry_ss = new SailorSoda();
            large_blackberry_ss.Size = Size.Large;
            large_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            drinks.Add(large_blackberry_ss);
            SailorSoda large_grapefruit_ss = new SailorSoda();
            large_grapefruit_ss.Size = Size.Large;
            large_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            drinks.Add(large_grapefruit_ss);
            SailorSoda large_lemon_ss = new SailorSoda();
            large_lemon_ss.Size = Size.Large;
            large_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            drinks.Add(large_lemon_ss);
            SailorSoda large_peach_ss = new SailorSoda();
            large_peach_ss.Size = Size.Large;
            large_peach_ss.SodaFlavor = SodaFlavor.Peach;
            drinks.Add(large_peach_ss);
            SailorSoda large_watermelon_ss = new SailorSoda();
            large_watermelon_ss.Size = Size.Large;
            large_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            drinks.Add(large_watermelon_ss);

            WarriorWater small_ww = new WarriorWater();
            small_ww.Size = Size.Small;
            drinks.Add(small_ww);
            WarriorWater medium_ww = new WarriorWater();
            medium_ww.Size = Size.Medium;
            drinks.Add(medium_ww);
            WarriorWater large_ww = new WarriorWater();
            large_ww.Size = Size.Large;
            drinks.Add(large_ww);

            return drinks;
        }

        /// <summary>
        /// FullMenu() should return an IEnumerable<IOrderItem> containing all of the items on the menu
        /// </summary>
        /// <returns>
        /// List of IOrderItem menu item instances
        /// </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            fullMenu.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            fullMenu.Add(dd);
            GardenOrcOmelette goo = new GardenOrcOmelette();
            fullMenu.Add(goo);
            PhillyPoacher pp = new PhillyPoacher();
            fullMenu.Add(pp);
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            fullMenu.Add(ss);
            ThalmorTriple tt = new ThalmorTriple();
            fullMenu.Add(tt);
            ThugsT_Bone tb = new ThugsT_Bone();
            fullMenu.Add(tb);

            DragonbornWaffleFries small_dwf = new DragonbornWaffleFries();
            small_dwf.Size = Size.Small;
            fullMenu.Add(small_dwf);
            DragonbornWaffleFries medium_dwf = new DragonbornWaffleFries();
            medium_dwf.Size = Size.Medium;
            fullMenu.Add(medium_dwf);
            DragonbornWaffleFries large_dwf = new DragonbornWaffleFries();
            large_dwf.Size = Size.Large;
            fullMenu.Add(large_dwf);

            FriedMiraak small_fm = new FriedMiraak();
            small_fm.Size = Size.Small;
            fullMenu.Add(small_fm);
            FriedMiraak medium_fm = new FriedMiraak();
            medium_fm.Size = Size.Medium;
            fullMenu.Add(medium_fm);
            FriedMiraak large_fm = new FriedMiraak();
            large_fm.Size = Size.Large;
            fullMenu.Add(large_fm);

            MadOtarGrits small_mog = new MadOtarGrits();
            small_mog.Size = Size.Small;
            fullMenu.Add(small_mog);
            MadOtarGrits medium_mog = new MadOtarGrits();
            medium_mog.Size = Size.Medium;
            fullMenu.Add(medium_mog);
            MadOtarGrits large_mog = new MadOtarGrits();
            large_mog.Size = Size.Large;
            fullMenu.Add(large_mog);

            VokunSalad small_vs = new VokunSalad();
            small_vs.Size = Size.Small;
            fullMenu.Add(small_vs);
            VokunSalad medium_vs = new VokunSalad();
            medium_vs.Size = Size.Medium;
            fullMenu.Add(medium_vs);
            VokunSalad large_vs = new VokunSalad();
            large_vs.Size = Size.Large;
            fullMenu.Add(large_vs);

            AretinoAppleJuice small_aj = new AretinoAppleJuice();
            small_aj.Size = Size.Small;
            fullMenu.Add(small_aj);
            AretinoAppleJuice medium_aj = new AretinoAppleJuice();
            medium_aj.Size = Size.Medium;
            fullMenu.Add(medium_aj);
            AretinoAppleJuice large_aj = new AretinoAppleJuice();
            large_aj.Size = Size.Large;
            fullMenu.Add(large_aj);

            CandlehearthCoffee small_cc = new CandlehearthCoffee();
            small_cc.Size = Size.Small;
            fullMenu.Add(small_cc);
            CandlehearthCoffee medium_cc = new CandlehearthCoffee();
            medium_cc.Size = Size.Medium;
            fullMenu.Add(medium_cc);
            CandlehearthCoffee large_cc = new CandlehearthCoffee();
            large_cc.Size = Size.Large;
            fullMenu.Add(large_cc);

            CandlehearthCoffee small_decaf_cc = new CandlehearthCoffee();
            small_decaf_cc.Size = Size.Small;
            small_decaf_cc.Decaf = true;
            fullMenu.Add(small_decaf_cc);
            CandlehearthCoffee medium_decaf_cc = new CandlehearthCoffee();
            medium_decaf_cc.Size = Size.Medium;
            medium_decaf_cc.Decaf = true;
            fullMenu.Add(medium_decaf_cc);
            CandlehearthCoffee large_decaf_cc = new CandlehearthCoffee();
            large_decaf_cc.Size = Size.Large;
            large_decaf_cc.Decaf = true;
            fullMenu.Add(large_decaf_cc);

            MarkarthMilk small_mm = new MarkarthMilk();
            small_mm.Size = Size.Small;
            fullMenu.Add(small_mm);
            MarkarthMilk medium_mm = new MarkarthMilk();
            medium_mm.Size = Size.Medium;
            fullMenu.Add(medium_mm);
            MarkarthMilk large_mm = new MarkarthMilk();
            large_mm.Size = Size.Large;
            fullMenu.Add(large_mm);

            SailorSoda small_cherry_ss = new SailorSoda();
            small_cherry_ss.Size = Size.Small;
            small_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            fullMenu.Add(small_cherry_ss);
            SailorSoda small_blackberry_ss = new SailorSoda();
            small_blackberry_ss.Size = Size.Small;
            small_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            fullMenu.Add(small_blackberry_ss);
            SailorSoda small_grapefruit_ss = new SailorSoda();
            small_grapefruit_ss.Size = Size.Small;
            small_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            fullMenu.Add(small_grapefruit_ss);
            SailorSoda small_lemon_ss = new SailorSoda();
            small_lemon_ss.Size = Size.Small;
            small_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            fullMenu.Add(small_lemon_ss);
            SailorSoda small_peach_ss = new SailorSoda();
            small_peach_ss.Size = Size.Small;
            small_peach_ss.SodaFlavor = SodaFlavor.Peach;
            fullMenu.Add(small_peach_ss);
            SailorSoda small_watermelon_ss = new SailorSoda();
            small_watermelon_ss.Size = Size.Small;
            small_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            fullMenu.Add(small_watermelon_ss);
            SailorSoda medium_cherry_ss = new SailorSoda();
            medium_cherry_ss.Size = Size.Medium;
            medium_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            fullMenu.Add(medium_cherry_ss);
            SailorSoda medium_blackberry_ss = new SailorSoda();
            medium_blackberry_ss.Size = Size.Medium;
            medium_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            fullMenu.Add(medium_blackberry_ss);
            SailorSoda medium_grapefruit_ss = new SailorSoda();
            medium_grapefruit_ss.Size = Size.Medium;
            medium_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            fullMenu.Add(medium_grapefruit_ss);
            SailorSoda medium_lemon_ss = new SailorSoda();
            medium_lemon_ss.Size = Size.Medium;
            medium_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            fullMenu.Add(medium_lemon_ss);
            SailorSoda medium_peach_ss = new SailorSoda();
            medium_peach_ss.Size = Size.Medium;
            medium_peach_ss.SodaFlavor = SodaFlavor.Peach;
            fullMenu.Add(medium_peach_ss);
            SailorSoda medium_watermelon_ss = new SailorSoda();
            medium_watermelon_ss.Size = Size.Medium;
            medium_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            fullMenu.Add(medium_watermelon_ss);

            SailorSoda large_cherry_ss = new SailorSoda();
            large_cherry_ss.Size = Size.Large;
            large_cherry_ss.SodaFlavor = SodaFlavor.Cherry;
            fullMenu.Add(large_cherry_ss);
            SailorSoda large_blackberry_ss = new SailorSoda();
            large_blackberry_ss.Size = Size.Large;
            large_blackberry_ss.SodaFlavor = SodaFlavor.Blackberry;
            fullMenu.Add(large_blackberry_ss);
            SailorSoda large_grapefruit_ss = new SailorSoda();
            large_grapefruit_ss.Size = Size.Large;
            large_grapefruit_ss.SodaFlavor = SodaFlavor.Grapefruit;
            fullMenu.Add(large_grapefruit_ss);
            SailorSoda large_lemon_ss = new SailorSoda();
            large_lemon_ss.Size = Size.Large;
            large_lemon_ss.SodaFlavor = SodaFlavor.Lemon;
            fullMenu.Add(large_lemon_ss);
            SailorSoda large_peach_ss = new SailorSoda();
            large_peach_ss.Size = Size.Large;
            large_peach_ss.SodaFlavor = SodaFlavor.Peach;
            fullMenu.Add(large_peach_ss);
            SailorSoda large_watermelon_ss = new SailorSoda();
            large_watermelon_ss.Size = Size.Large;
            large_watermelon_ss.SodaFlavor = SodaFlavor.Watermelon;
            fullMenu.Add(large_watermelon_ss);

            WarriorWater small_ww = new WarriorWater();
            small_ww.Size = Size.Small;
            fullMenu.Add(small_ww);
            WarriorWater medium_ww = new WarriorWater();
            medium_ww.Size = Size.Medium;
            fullMenu.Add(medium_ww);
            WarriorWater large_ww = new WarriorWater();
            large_ww.Size = Size.Large;
            fullMenu.Add(large_ww);

            return fullMenu;
        }


        /// <summary>
        /// Gets the possible MPAARatings
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }


        /// <summary>
        /// Searches the menu items for matches
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null) return orderItems;

            foreach (IOrderItem item in orderItems)
            {
                if (item.ToString() != null && item.ToString().Contains(terms))
                {
                    //Add the item if the term is in the name
                    results.Add(item);
                }
                if (item.Description != null && item.Description.Contains(terms))
                {
                    //Add the item if the description matches a term
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="orderItems">The collection of items to filter</param>
        /// <param name="category">The type to include</param>
        /// <returns>A collection containing only menu items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> category)
        {
            // TODO: Filter the list
            // If no filter is specified, just return the provided collection
            if (category == null || category.Count() == 0) return orderItems;
            // Filter the supplied collection of menu items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in orderItems)
            {
                if (category != null && Category.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                if (category != null && Category.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
                if (category != null && Category.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items by price
        /// </summary>
        /// <param name="orderItems">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            // TODO: Filter menu items
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }



        /// <summary>
        /// Filters the provided collection of menu items by calories
        /// </summary>
        /// <param name="orderItems">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            // TODO: Filter menu items
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
