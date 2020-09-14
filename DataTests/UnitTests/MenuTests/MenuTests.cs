/*Author: Mason Dunsmore
 * Class: MenuTests.cs
 * Purpose: To make sure that all of the items are in the menu class
 * 
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Sides;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveCorrectEntrees()
        {
            IEnumerable<IOrderItem> e = Menu.Entrees();
            Assert.Collection(e,
                item =>
                {
                    Assert.Equal(item.ToString(), new BriarheartBurger().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DoubleDraugr().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new GardenOrcOmelette().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new PhillyPoacher().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SmokehouseSkeleton().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new ThalmorTriple().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new ThugsTBone().ToString());
                });
        }
        [Fact]
        public void ShouldHaveCorrectDrinks()
        {
            IEnumerable<IOrderItem> i = Menu.Drinks();
            Assert.Collection(i,
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Watermelon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Watermelon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Watermelon).ToString());
                });
        }
        [Fact]
        public void ShouldHaveCorrectSides()
        {
            IEnumerable<IOrderItem> s = Menu.Sides();
            Assert.Collection(s,
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad(Size.Large).ToString());
                });
        }
        [Fact]
        public void ShouldHaveCorrectFullMenu()
        {
            IEnumerable<IOrderItem> f = Menu.FullMenu();
            Assert.Collection(f,
                item =>
                {
                    Assert.Equal(item.ToString(), new BriarheartBurger().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DoubleDraugr().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new GardenOrcOmelette().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new PhillyPoacher().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SmokehouseSkeleton().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new ThalmorTriple().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new ThugsTBone().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad().ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new VokunSalad(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Small).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Medium).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new WarriorWater(Size.Large).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Watermelon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Watermelon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Blackberry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Cherry).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Grapefruit).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Lemon).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Peach).ToString());
                },
                item =>
                {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Watermelon).ToString());
                });
        }
    }
}
