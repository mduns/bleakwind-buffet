﻿/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal<uint>(602, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var ss = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if(includePancake && includeSausage && includeHashbrowns && includeEgg)
            {
                Assert.Empty(ss.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
                Assert.Contains("Hold egg", ss.SpecialInstructions);
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = false;
            });
            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = true;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });
            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = true;
            });
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", ss.Description);
        }
    }
}