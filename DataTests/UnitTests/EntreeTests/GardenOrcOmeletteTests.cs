﻿/*
 * Author: Mason Dunsmore and Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            var go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(go);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            var go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var go = new GardenOrcOmelette();
            go.Broccoli = false;
            Assert.False(go.Broccoli);
            go.Broccoli = true;
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var go = new GardenOrcOmelette();
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var go = new GardenOrcOmelette();
            go.Tomato = false;
            Assert.False(go.Tomato);
            go.Tomato = true;
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var go = new GardenOrcOmelette();
            go.Cheddar = false;
            Assert.False(go.Cheddar);
            go.Cheddar = true;
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var go = new GardenOrcOmelette();
            Assert.Equal<uint>(404, go.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var go = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if(includeCheddar && includeBroccoli && includeMushrooms && includeTomato)
            {
                Assert.Empty(go.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold broccoli", go.SpecialInstructions);
                Assert.Contains("Hold mushrooms", go.SpecialInstructions);
                Assert.Contains("Hold cheddar", go.SpecialInstructions);
                Assert.Contains("Hold tomato", go.SpecialInstructions);
            }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = false;
            });
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = true;
            });
        }
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = false;
            });
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = true;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = false;
            });
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = true;
            });
        }
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = false;
            });
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = true;
            });
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(go);
        }
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var go = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", go.Description);
        }
    }
}