/*
 * Author: Zachery Brunner
 * Edited by: Bree Reynoso
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Bun", () =>
            {
                DD.Bun = true;
            });

            Assert.PropertyChanged(DD, "Bun", () =>
            {
                DD.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Ketchup", () =>
            {
                DD.Ketchup = true;
            });

            Assert.PropertyChanged(DD, "Ketchup", () =>
            {
                DD.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Mustard", () =>
            {
                DD.Mustard = true;
            });

            Assert.PropertyChanged(DD, "Mustard", () =>
            {
                DD.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Pickle", () =>
            {
                DD.Pickle = true;
            });

            Assert.PropertyChanged(DD, "Pickle", () =>
            {
                DD.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Cheese", () =>
            {
                DD.Cheese = true;
            });

            Assert.PropertyChanged(DD, "Cheese", () =>
            {
                DD.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Tomato", () =>
            {
                DD.Tomato = true;
            });

            Assert.PropertyChanged(DD, "Tomato", () =>
            {
                DD.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Lettuce", () =>
            {
                DD.Lettuce = true;
            });

            Assert.PropertyChanged(DD, "Lettuce", () =>
            {
                DD.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Mayo", () =>
            {
                DD.Mayo = true;
            });

            Assert.PropertyChanged(DD, "Mayo", () =>
            {
                DD.Mayo = false;
            });
        }


        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }


        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);

        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            uint cal = 843;
            Assert.Equal(cal, dd.Calories);
        }


        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };

            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo) Assert.Empty(dd.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            string name = "Double Draugr";
            Assert.Equal(name, dd.ToString());
        }
    }
}