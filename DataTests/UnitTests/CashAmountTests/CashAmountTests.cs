/*Author: Mason Dunsmore
 * Class: CashAmountTests
 * Purpose: Test the CashAmount Class
 * 
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.CashAmountTests
{
    public class CashAmountTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHundredAmount(int n)
        {
            var c = new CashAmount();
            c.HundredAmount = n;
            Assert.Equal(n, c.HundredAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyAmount(int n)
        {
            var c = new CashAmount();
            c.FiftyAmount = n;
            Assert.Equal(n, c.FiftyAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentyAmount(int n)
        {
            var c = new CashAmount();
            c.TwentyAmount = n;
            Assert.Equal(n, c.TwentyAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenAmount(int n)
        {
            var c = new CashAmount();
            c.TenAmount = n;
            Assert.Equal(n, c.TenAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveAmount(int n)
        {
            var c = new CashAmount();
            c.FiveAmount = n;
            Assert.Equal(n, c.FiveAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneAmount(int n)
        {
            var c = new CashAmount();
            c.OneAmount = n;
            Assert.Equal(n, c.OneAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyCentAmount(int n)
        {
            var c = new CashAmount();
            c.FiftyCentAmount = n;
            Assert.Equal(n, c.FiftyCentAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentyFiveCentAmount(int n)
        {
            var c = new CashAmount();
            c.TwentyFiveCentAmount = n;
            Assert.Equal(n, c.TwentyFiveCentAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenCentAmount(int n)
        {
            var c = new CashAmount();
            c.TenCentAmount = n;
            Assert.Equal(n, c.TenCentAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveCentAmount(int n)
        {
            var c = new CashAmount();
            c.FiveCentAmount = n;
            Assert.Equal(n, c.FiveCentAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneCentAmount(int n)
        {
            var c = new CashAmount();
            c.OneCentAmount = n;
            Assert.Equal(n, c.OneCentAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHundredChangeAmount(int n)
        {
            var c = new CashAmount();
            c.HundredChangeAmount = n;
            Assert.Equal(n, c.HundredChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyChangeAmount(int n)
        {
            var c = new CashAmount();
            c.FiftyChangeAmount = n;
            Assert.Equal(n, c.FiftyChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentyChangeAmount(int n)
        {
            var c = new CashAmount();
            c.TwentyChangeAmount = n;
            Assert.Equal(n, c.TwentyChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenChangeAmount(int n)
        {
            var c = new CashAmount();
            c.TenChangeAmount = n;
            Assert.Equal(n, c.TenChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveChangeAmount(int n)
        {
            var c = new CashAmount();
            c.FiveChangeAmount = n;
            Assert.Equal(n, c.FiveChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneChangeAmount(int n)
        {
            var c = new CashAmount();
            c.OneChangeAmount = n;
            Assert.Equal(n, c.OneChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyCentChangeAmount(int n)
        {
            var c = new CashAmount();
            c.FiftyCentChangeAmount = n;
            Assert.Equal(n, c.FiftyCentChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentyFiveCentChangeAmount(int n)
        {
            var c = new CashAmount();
            c.TwentyFiveCentChangeAmount = n;
            Assert.Equal(n, c.TwentyFiveCentChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenCentChangeAmount(int n)
        {
            var c = new CashAmount();
            c.TenCentChangeAmount = n;
            Assert.Equal(n, c.TenCentChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveCentChangeAmount(int n)
        {
            var c = new CashAmount();
            c.FiveCentChangeAmount = n;
            Assert.Equal(n, c.FiveCentChangeAmount);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneCentChangeAmount(int n)
        {
            var c = new CashAmount();
            c.OneCentChangeAmount = n;
            Assert.Equal(n, c.OneCentChangeAmount);
        }
        [Fact]
        public void TotalDueShouldStartAtZero()
        {
            var c = new CashAmount();
            Assert.Equal(0, c.TotalDue);
        }
        [Fact] 
        public void TotalCashShouldStartAtZero()
        {
            var c = new CashAmount();
            Assert.Equal(0, c.TotalCash);
        }
        [Fact] 
        public void AmountOwedShouldStartAtZero()
        {
            var c = new CashAmount();
            Assert.Equal(0, c.AmountOwed);
        }
        [Fact]
        public void ChangeDueShouldStartAtZero()
        {
            var c = new CashAmount();
            Assert.Equal(0, c.ChangeDue);
        }
        [Theory]
        [InlineData(35.32)]
        [InlineData(90.21)]
        [InlineData(1000.11)]
        public void ShouldBeAbleToSetTotalDue(double n)
        {
            var c = new CashAmount();
            c.TotalDue = n;
            Assert.Equal(n, c.TotalDue);
        }
        [Fact]
        public void TotalCashShouldBeSetByEachAmount()
        {
            var c = new CashAmount();
            c.HundredAmount = 1;
            c.FiftyAmount = 1;
            c.TwentyAmount = 1;
            c.TenAmount = 1;
            c.FiveAmount = 1;
            c.OneAmount = 4;
            c.FiftyCentAmount = 1;
            c.TwentyFiveCentAmount = 1;
            c.TenCentAmount = 1;
            c.FiveCentAmount = 1;
            c.OneCentAmount = 4;
            Assert.Equal(189.94, c.TotalCash);
        }
        [Theory]
        [InlineData(80, 100, 2)]
        [InlineData(0, 15, 2)]
        public void AmountOwedShouldBeTotalDueMinusTotalCashIfPositive(double result, double total, int cash)
        {
            var c = new CashAmount();
            c.TotalDue = total;
            c.TenAmount = cash;
            Assert.Equal(result, c.AmountOwed);
        }
        [Theory]
        [InlineData(0, 100, 2)]
        [InlineData(5, 15, 2)]
        public void AmountOwedShouldBeTotalCashMinusTotalDueIfPositive(double result, double total, int cash)
        {
            var c = new CashAmount();
            c.TotalDue = total;
            c.TenAmount = cash;
            Assert.Equal(result, c.ChangeDue);
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var c = new CashAmount();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
    }
}
