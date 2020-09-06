/* Author: Mason Dunsmore 
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs Class in the Data Library
 */
using System;
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var ww = new WarriorWater();
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
        }
        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var ww = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(price, ww.Price);
        }
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var ww = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (includeIce && !includeLemon) Assert.Empty(ww.SpecialInstructions);
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
        }
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldHaveCorrectToStringBasedOnSize(Size size, string name)
        {
            var ww = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(name, ww.ToString());
        }
    }
}
