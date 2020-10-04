﻿/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var pp = new PhillyPoacher();
            Assert.Equal<uint>(784, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var pp = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if(includeRoll && includeOnion && includeSirloin)
            {
                Assert.Empty(pp.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
                Assert.Contains("Hold onion", pp.SpecialInstructions);
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });
        }
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });
        }
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });
        }
    }
}