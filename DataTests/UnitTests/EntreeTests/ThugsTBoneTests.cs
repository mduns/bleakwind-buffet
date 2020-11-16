/*
 * Author: Mason Dunsmore and Zachery Brunner
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
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var tb = new ThugsTBone();
            Assert.Equal<uint>(982, tb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tb);
        }
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var tb = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", tb.Description);
        }
    }
}