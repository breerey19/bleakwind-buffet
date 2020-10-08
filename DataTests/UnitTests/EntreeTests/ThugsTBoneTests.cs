/*
 * Author: Zachery Brunner
 * Edited by: Bree Reynoso
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        //[Fact]
        //public void ShouldImplementINotifyPropertyChanged()
        //{
        //    ThugsT_Bone tb = new ThugsT_Bone();
        //    Assert.IsAssignableFrom<INotifyPropertyChanged>(tb);
        //}

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsT_Bone tb = new ThugsT_Bone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsT_Bone tb = new ThugsT_Bone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsT_Bone tb = new ThugsT_Bone();
            uint cal = 982;
            Assert.Equal(cal, tb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsT_Bone tb = new ThugsT_Bone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsT_Bone tb = new ThugsT_Bone();
            string name = "Thugs T-Bone";
            Assert.Equal(name, tb.ToString());
        }
    }
}