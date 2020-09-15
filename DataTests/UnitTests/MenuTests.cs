/*
 * Author: Bree Reynoso
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Xunit;


namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
            var goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
            var tb = new ThugsT_Bone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldBeAbleToCastEntreesFromIOrderItem()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
            var goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
            var tb = new ThugsT_Bone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dwf);
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
            var mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeAbleToSidesCastFromIOrderItem()
        {
            var dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dwf);
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
            var mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
            var cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
            var ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldBeAbleToCaseDrinksFromIOrderItem()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
            var cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
            var ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldReturnAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsT_Bone; });
        }

        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]

        public void ShouldReturnAllSides(string name)
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals(name);});

        }

        [Fact]
        public void ShouldReturnAllDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void FullMenuShouldContainFullMenu()
        {
            Assert.Contains(Menu.FullMenu(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThugsT_Bone; });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Warrior Water"); });

        }

    }
}
