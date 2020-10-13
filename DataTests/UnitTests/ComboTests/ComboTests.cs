using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.ComboTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var c = new Combo();
            var aa = new AretinoAppleJuice();
            var bb = new BriarheartBurger();
            var dwf = new DragonbornWaffleFries();
            c.Drink = aa;
            c.Entree = bb;
            c.Side = dwf;
            Assert.Equal(aa.Price + bb.Price + dwf.Price - 1, c.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            var c = new Combo();
            var cc = new CandlehearthCoffee();
            var dd = new DoubleDraugr();
            var fm = new FriedMiraak();
            c.Drink = cc;
            c.Entree = dd;
            c.Side = fm;
            Assert.Equal(1001, (int)c.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectSpecialInstructions()
        {
            var c = new Combo();
            var mm = new MarkarthMilk();
            var go = new GardenOrcOmelette();
            var mo = new MadOtarGrits();
            go.Broccoli = false;
            mm.Ice = true;
            c.Entree = go;
            c.Side = mo;
            c.Drink = mm;
            List<string> instructions = new List<string>();
            instructions.Add(go.ToString());
            foreach(string i in go.SpecialInstructions)
            {
                instructions.Add(i);
            }
            instructions.Add(mo.ToString());
            foreach(string j in mo.SpecialInstructions)
            {
                instructions.Add(j);
            }
            instructions.Add(mm.ToString());
            foreach(string k in mm.SpecialInstructions)
            {
                instructions.Add(k);
            }
            foreach(string l in instructions)
            {
                Assert.Contains(l, c.SpecialInstructions);
            }
        }
        [Fact]
        public void ShouldChangeSpecialInstructionsIfItemChanges()
        {
            var c = new Combo();
            var mm = new MarkarthMilk();
            var go = new GardenOrcOmelette();
            var mo = new MadOtarGrits();
            go.Broccoli = false;
            mm.Ice = true;
            c.Entree = go;
            c.Side = mo;
            c.Drink = mm;
            List<string> instructions = new List<string>();
            instructions.Add(go.ToString());
            foreach (string i in go.SpecialInstructions)
            {
                instructions.Add(i);
            }
            instructions.Add(mo.ToString());
            foreach (string j in mo.SpecialInstructions)
            {
                instructions.Add(j);
            }
            instructions.Add(mm.ToString());
            foreach (string k in mm.SpecialInstructions)
            {
                instructions.Add(k);
            }
            foreach (string l in instructions)
            {
                Assert.Contains(l, c.SpecialInstructions);
            }
            var ss = new SailorSoda();
            ss.Ice = false;
            var pp = new PhillyPoacher();
            pp.Onion = false;
            pp.Roll = false;
            var vs = new VokunSalad();
            c.Drink = ss;
            c.Entree = pp;
            c.Side = vs;
            List<string> newInstructions = new List<string>();
            newInstructions.Add(ss.ToString());
            foreach (string i in ss.SpecialInstructions)
            {
                newInstructions.Add(i);
            }
            newInstructions.Add(pp.ToString());
            foreach (string j in mo.SpecialInstructions)
            {
                newInstructions.Add(j);
            }
            newInstructions.Add(pp.ToString());
            foreach (string k in vs.SpecialInstructions)
            {
                newInstructions.Add(k);
            }
            newInstructions.Add(vs.ToString());
            foreach (string l in newInstructions)
            {
                Assert.Contains(l, c.SpecialInstructions);
            }
        }
        [Fact]
        public void ShouldBeAnINotifyPropertyChanged()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
        [Fact]
        public void AddingDrinkShouldNotifyDrinkPriceCaloriesAndSpecialInstructions()
        {
            var c = new Combo();
            var ww = new WarriorWater();
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = ww;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = ww;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = ww;
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = ww;
            });
        }
        [Fact]
        public void AddingEntreeShouldNotifyEntreePriceCaloriesAndSpecialInstructions()
        {
            var c = new Combo();
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = ss;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = ss;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = ss;
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = ss;
            });
        }
        [Fact]
        public void AddingSideShouldNotifySidePriceCaloriesAndSpecialInstructions()
        {
            var c = new Combo();
            var dw = new DragonbornWaffleFries();
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = dw;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = dw;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = dw;
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = dw;
            });
        }
        [Fact]
        public void ChangingObjectPriceShouldNotifyPriceProperty()
        {
            var c = new Combo();
            var dw = new DragonbornWaffleFries();
            var mm = new MarkarthMilk();
            c.Side = dw;
            c.Drink = mm;
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side.Size = Size.Large;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingObjectCaloriesShouldNotifyCaloriesProperty()
        {
            var c = new Combo();
            var dw = new DragonbornWaffleFries();
            var mm = new MarkarthMilk();
            c.Side = dw;
            c.Drink = mm;
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side.Size = Size.Large;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink.Size = Size.Large;
            });
        }
            [Fact]
        public void ChangingObjectSpecialInstructionsShouldNotifySpecialInstructionsProperty()
        {
            var c = new Combo();
            var dw = new DragonbornWaffleFries();
            var mm = new MarkarthMilk();
            var bb = new BriarheartBurger();
            c.Side = dw;
            c.Drink = mm;
            c.Entree = bb;
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                mm.Ice = true;
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                bb.Bun = false;
                bb.Cheese = false;
            });
        }
    }
}
