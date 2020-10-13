/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var mo = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mo);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var mo = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mo);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var mo = new MadOtarGrits();
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var mo = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(price, mo.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var mo = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var mo = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(name, mo.ToString());
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Small;
            });
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Medium;
            });
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Large;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Price", () =>
            {
                mo.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var mo = new MadOtarGrits();
            Assert.PropertyChanged(mo, "Calories", () =>
            {
                mo.Size = size;
            });
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var mo = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mo);
        }
    }
}