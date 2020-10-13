/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dw);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dw);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var dw = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var dw = new DragonbornWaffleFries();
            dw.Size = Size.Medium;
            Assert.Equal(Size.Medium, dw.Size);
            dw.Size = Size.Large;
            Assert.Equal(Size.Large, dw.Size);
            dw.Size = Size.Small;
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var dw = new DragonbornWaffleFries();
            Assert.Empty(dw.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var dw = new DragonbornWaffleFries()
            {
                Size = size,
            };
            Assert.Equal(price, dw.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var dw = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(calories, dw.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var dw = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(name, dw.ToString());
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Small;
            });
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Medium;
            });
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Large;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Price", () =>
            {
                dw.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(dw, "Calories", () =>
            {
                dw.Size = size;
            });
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dw);
        }
    }
}