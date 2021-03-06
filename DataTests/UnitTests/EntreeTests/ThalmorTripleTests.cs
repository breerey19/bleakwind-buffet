﻿/*
 * Author: Zachery Brunner
 * Edited by: Bree Reynoso
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = true;
            });

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = true;
            });

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = true;
            });

            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = true;
            });

            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = true;
            });

            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = true;
            });

            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = true;
            });

            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = true;
            });

            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = true;
            });

            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = true;
            });

            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = false;
            });
        }


        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }


        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);

        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            uint cal = 943;
            Assert.Equal(cal, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };

            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce 
                && includeMayo && includeBacon && includeEgg) Assert.Empty(tt.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            string name = "Thalmor Triple";
            Assert.Equal(name, tt.ToString());
        }
    }
}