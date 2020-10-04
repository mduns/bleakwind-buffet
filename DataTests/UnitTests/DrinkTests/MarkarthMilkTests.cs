/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var mm = new MarkarthMilk();
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var mm = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var mm = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var mm = new MarkarthMilk()
            {
                Ice = includeIce
            };
            if (includeIce) Assert.Contains("Add ice", mm.SpecialInstructions);
            if (!includeIce) Assert.Empty(mm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var mm = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(name, mm.ToString());
        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });
            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = size;
            });
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = size;
            });
        }
    }
}