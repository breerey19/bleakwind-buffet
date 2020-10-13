/*
 * Author: Zachery Brunner
 * Edited by: Bree Reynoso
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SausageLink", () =>
            {
                SS.SausageLink = true;
            });

            Assert.PropertyChanged(SS, "SausageLink", () =>
            {
                SS.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "Egg", () =>
            {
                SS.Egg = true;
            });

            Assert.PropertyChanged(SS, "Egg", () =>
            {
                SS.Egg = false;
            });
        }

        [Fact]
        public void ChangingHashbrownsNotifiesHashbrownsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "Hashbrowns", () =>
            {
                SS.Hashbrowns = true;
            });

            Assert.PropertyChanged(SS, "Hashbrowns", () =>
            {
                SS.Hashbrowns = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "Pancake", () =>
            {
                SS.Pancake = true;
            });

            Assert.PropertyChanged(SS, "Pancake", () =>
            {
                SS.Pancake = false;
            });
        }


        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }



        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldIncludeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldIncludeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Hashbrowns);
        }

        [Fact]
        public void ShouldIncludePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);

        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Hashbrowns = true;
            Assert.True(ss.Hashbrowns);
            ss.Hashbrowns = false;
            Assert.False(ss.Hashbrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, ss.Calories);

        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var ss = new SmokehouseSkeleton
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                Hashbrowns = includeHashbrowns,
                Pancake = includePancake,
            };

            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            string name = "Smokehouse Skeleton";
            Assert.Equal(name, ss.ToString());
        }
    }
}