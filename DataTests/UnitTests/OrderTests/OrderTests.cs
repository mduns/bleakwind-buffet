/*
 * Author: Mason Dunsmore
 * Class: OrderTests.cs
 * Purpose: Test the Order class in the Data library
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.OrderTests
{
    public class OrderTests
    {
        [Fact]
        public void NextOrderNumberShouldIncrementForEveryOrder()
        {
            var o = new Order();
            Assert.Equal(1, o.Number);
            var or = new Order();
            Assert.Equal(2, or.Number);
            var ord = new Order();
            Assert.Equal(3, ord.Number);
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }
        /*[Fact]
        public void AddingToOrderShouldTriggerCollectionChangedEvent()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            o.Add(aj);
        }*/
        [Fact]
        public void AddingIOrderItemShouldTriggerSubtotalTaxTotalCaloriesPropertyChanges()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(aj);
            });
            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(aj);
            });
            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(aj);
            });
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(aj);
            });
        }
        [Fact]
        public void RemovingIOrderItemShouldTriggerSubtotalTaxTotalCaloriesPropertyChanges()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            o.Add(aj);
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Remove(aj);
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Remove(aj);
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Remove(aj);
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Remove(aj);
            });
        }
        [Fact]
        public void ChangingItemPriceShouldTriggerPropertyChangeForSubtotalTaxAndTotal()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            o.Add(aj);
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                aj.Size = Data.Enums.Size.Medium;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Total", () =>
            {
                aj.Size = Data.Enums.Size.Large;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Tax", () =>
            {
                aj.Size = Data.Enums.Size.Medium;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Calories", () =>
            {
                aj.Size = Data.Enums.Size.Large;
            });
        }
        [Fact]
        public void ChangingItemCaloriesShouldTriggerPropertyChangeForSubtotalTaxAndTotal()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            o.Add(aj);
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                aj.Size = Data.Enums.Size.Medium;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Total", () =>
            {
                aj.Size = Data.Enums.Size.Large;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Tax", () =>
            {
                aj.Size = Data.Enums.Size.Medium;
            });
            o.Add(aj);
            Assert.PropertyChanged(o, "Calories", () =>
            {
                aj.Size = Data.Enums.Size.Large;
            });
        }
        [Fact]
        public void SubtotalAddsAllItemPricesTogether()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            var bb = new BriarheartBurger();
            var vs = new VokunSalad();
            o.Add(aj);
            o.Add(bb);
            o.Add(vs);
            Assert.Equal(aj.Price + bb.Price + vs.Price, o.Subtotal);
        }
        [Fact]
        public void CaloriesAddsAllItemCaloriesTogether()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            var bb = new BriarheartBurger();
            var vs = new VokunSalad();
            o.Add(aj);
            o.Add(bb);
            o.Add(vs);
            Assert.Equal(aj.Calories + bb.Calories + vs.Calories, o.Calories);
        }
        [Fact]
        public void TotalShouldBeSubtotalPlusTax()
        {
            var o = new Order();
            var aj = new AretinoAppleJuice();
            o.Add(aj);
            Assert.Equal(o.Subtotal + o.Tax, o.Total);
        }
    }
}
