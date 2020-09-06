/*
 * Author: Zachery Brunner
 * Edited by: Bree Reynoso
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
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
            if (!includeEgg) Assert.Contains("Hold egg", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancake", ss.SpecialInstructions);
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