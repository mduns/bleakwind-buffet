/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var dd = new DoubleDraugr();
            Assert.Equal<uint>(843, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            var dd = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };
            if (includeBun && includeCheese && includeKetchup && includeLettuce && includeMayo && includeMustard && includePickle
                && includeTomato) Assert.Empty(dd.SpecialInstructions);
            else
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var dd = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", dd.Description);
        }
    }
}