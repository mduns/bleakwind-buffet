/*
 * Author: Mason Dunsmore
 * Class: Menu.cs
 * Purpose: Holds objects for every menu item 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Linq;
using System.IO;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// Holds objects for every menu item
    /// </summary>
    public static class Menu
    {

        public static string[] Category
        {
            get => new string[] { "Entree", "Side", "Drink" };
        }
        /// <summary>
        /// creates a list that has every entree in it
        /// </summary>
        /// <returns> a list<IOrderItem> with every entree </IOrderItem></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var bb = new BriarheartBurger();
            var dd = new DoubleDraugr();
            var go = new GardenOrcOmelette();
            var pp = new PhillyPoacher();
            var ss = new SmokehouseSkeleton();
            var tt = new ThalmorTriple();
            var tb = new ThugsTBone();
            IEnumerable<IOrderItem> items = new List<IOrderItem>() { bb, dd, go, pp, ss, tt, tb };
            return items;
        }
        /// <summary>
        /// initializes every side object and puts them in a list
        /// </summary>
        /// <returns> List<IOrderItem> with every side in it </IOrderItem></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var dw_s = new DragonbornWaffleFries();
            dw_s.Size = Size.Small;
            var fm_s = new FriedMiraak();
            fm_s.Size = Size.Small;
            var mo_s = new MadOtarGrits();
            mo_s.Size = Size.Small;
            var vs_s = new VokunSalad();
            vs_s.Size = Size.Small;
            var dw_m = new DragonbornWaffleFries();
            dw_m.Size = Size.Medium;
            var fm_m = new FriedMiraak();
            fm_m.Size = Size.Medium;
            var mo_m = new MadOtarGrits();
            mo_m.Size = Size.Medium;
            var vs_m = new VokunSalad();
            vs_m.Size = Size.Medium;
            var dw_l = new DragonbornWaffleFries();
            dw_l.Size = Size.Large;
            var fm_l = new FriedMiraak();
            fm_l.Size = Size.Large;
            var mo_l = new MadOtarGrits();
            mo_l.Size = Size.Large;
            var vs_l = new VokunSalad();
            vs_l.Size = Size.Large;
            IEnumerable<IOrderItem> items = new List<IOrderItem>() { dw_s, fm_s, mo_s, vs_s, dw_m, fm_m, mo_m, vs_m, dw_l,
            fm_l, mo_l, vs_l};
            return items;
        }
        /// <summary>
        /// initializes every type of drink possible and puts it in a list
        /// </summary>
        /// <returns>List<IOrderItem> with every drink possibility in it </IOrderItem></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var aj_s = new AretinoAppleJuice();
            aj_s.Size = Size.Small;
            var cc_s = new CandlehearthCoffee();
            cc_s.Size = Size.Small;
            var mm_s = new MarkarthMilk();
            mm_s.Size = Size.Small;
            var ww_s = new WarriorWater();
            ww_s.Size = Size.Small;
            var aj_m = new AretinoAppleJuice();
            aj_m.Size = Size.Medium;
            var cc_m = new CandlehearthCoffee();
            cc_m.Size = Size.Medium;
            var mm_m = new MarkarthMilk();
            mm_m.Size = Size.Medium;
            var ww_m = new WarriorWater();
            ww_m.Size = Size.Medium;
            var aj_l = new AretinoAppleJuice();
            aj_l.Size = Size.Large;
            var cc_l = new CandlehearthCoffee();
            cc_l.Size = Size.Large;
            var mm_l = new MarkarthMilk();
            mm_l.Size = Size.Large;
            var ww_l = new WarriorWater();
            ww_l.Size = Size.Large;
            var ss_s_b = new SailorSoda();
            ss_s_b.Size = Size.Small;
            ss_s_b.Flavor = SodaFlavor.Blackberry;
            var ss_s_c = new SailorSoda();
            ss_s_c.Size = Size.Small;
            ss_s_c.Flavor = SodaFlavor.Cherry;
            var ss_s_g = new SailorSoda();
            ss_s_g.Size = Size.Small;
            ss_s_g.Flavor = SodaFlavor.Grapefruit;
            var ss_s_l = new SailorSoda();
            ss_s_l.Size = Size.Small;
            ss_s_l.Flavor = SodaFlavor.Lemon;
            var ss_s_p = new SailorSoda();
            ss_s_p.Size = Size.Small;
            ss_s_p.Flavor = SodaFlavor.Peach;
            var ss_s_w = new SailorSoda();
            ss_s_w.Size = Size.Small;
            ss_s_w.Flavor = SodaFlavor.Watermelon;
            var ss_m_b = new SailorSoda();
            ss_m_b.Size = Size.Medium;
            ss_m_b.Flavor = SodaFlavor.Blackberry;
            var ss_m_c = new SailorSoda();
            ss_m_c.Size = Size.Medium;
            ss_m_c.Flavor = SodaFlavor.Cherry;
            var ss_m_g = new SailorSoda();
            ss_m_g.Size = Size.Medium;
            ss_m_g.Flavor = SodaFlavor.Grapefruit;
            var ss_m_l = new SailorSoda();
            ss_m_l.Size = Size.Medium;
            ss_m_l.Flavor = SodaFlavor.Lemon;
            var ss_m_p = new SailorSoda();
            ss_m_p.Size = Size.Medium;
            ss_m_p.Flavor = SodaFlavor.Peach;
            var ss_m_w = new SailorSoda();
            ss_m_w.Size = Size.Medium;
            ss_m_w.Flavor = SodaFlavor.Watermelon;
            var ss_l_b = new SailorSoda();
            ss_l_b.Size = Size.Large;
            ss_l_b.Flavor = SodaFlavor.Blackberry;
            var ss_l_c = new SailorSoda();
            ss_l_c.Size = Size.Large;
            ss_l_c.Flavor = SodaFlavor.Cherry;
            var ss_l_g = new SailorSoda();
            ss_l_g.Size = Size.Large;
            ss_l_g.Flavor = SodaFlavor.Grapefruit;
            var ss_l_l = new SailorSoda();
            ss_l_l.Size = Size.Large;
            ss_l_l.Flavor = SodaFlavor.Lemon;
            var ss_l_p = new SailorSoda();
            ss_l_p.Size = Size.Large;
            ss_l_p.Flavor = SodaFlavor.Peach;
            var ss_l_w = new SailorSoda();
            ss_l_w.Size = Size.Large;
            ss_l_w.Flavor = SodaFlavor.Watermelon;
            IEnumerable<IOrderItem> items = new List<IOrderItem> { aj_s, cc_s, mm_s, ww_s, aj_m, cc_m, mm_m, ww_m, aj_l,
            cc_l, mm_l, ww_l, ss_s_b, ss_s_c, ss_s_g, ss_s_l, ss_s_p, ss_s_w, ss_m_b, ss_m_c, ss_m_g, ss_m_l, ss_m_p, ss_m_w,
            ss_l_b, ss_l_c, ss_l_g, ss_l_l, ss_l_p, ss_l_w};
            return items;
        }
        /// <summary>
        /// initializes every item on the menu and puts it in a list
        /// </summary>
        /// <returns> a list<IOrderItem> with every item on the menu</IOrderItem></returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            var bb = new BriarheartBurger();
            var dd = new DoubleDraugr();
            var go = new GardenOrcOmelette();
            var pp = new PhillyPoacher();
            var ss = new SmokehouseSkeleton();
            var tt = new ThalmorTriple();
            var tb = new ThugsTBone();
            var dw_s = new DragonbornWaffleFries();
            dw_s.Size = Size.Small;
            var fm_s = new FriedMiraak();
            fm_s.Size = Size.Small;
            var mo_s = new MadOtarGrits();
            mo_s.Size = Size.Small;
            var vs_s = new VokunSalad();
            vs_s.Size = Size.Small;
            var dw_m = new DragonbornWaffleFries();
            dw_m.Size = Size.Medium;
            var fm_m = new FriedMiraak();
            fm_m.Size = Size.Medium;
            var mo_m = new MadOtarGrits();
            mo_m.Size = Size.Medium;
            var vs_m = new VokunSalad();
            vs_m.Size = Size.Medium;
            var dw_l = new DragonbornWaffleFries();
            dw_l.Size = Size.Large;
            var fm_l = new FriedMiraak();
            fm_l.Size = Size.Large;
            var mo_l = new MadOtarGrits();
            mo_l.Size = Size.Large;
            var vs_l = new VokunSalad();
            vs_l.Size = Size.Large;
            var aj_s = new AretinoAppleJuice();
            aj_s.Size = Size.Small;
            var cc_s = new CandlehearthCoffee();
            cc_s.Size = Size.Small;
            var mm_s = new MarkarthMilk();
            mm_s.Size = Size.Small;
            var ww_s = new WarriorWater();
            ww_s.Size = Size.Small;
            var aj_m = new AretinoAppleJuice();
            aj_m.Size = Size.Medium;
            var cc_m = new CandlehearthCoffee();
            cc_m.Size = Size.Medium;
            var mm_m = new MarkarthMilk();
            mm_m.Size = Size.Medium;
            var ww_m = new WarriorWater();
            ww_m.Size = Size.Medium;
            var aj_l = new AretinoAppleJuice();
            aj_l.Size = Size.Large;
            var cc_l = new CandlehearthCoffee();
            cc_l.Size = Size.Large;
            var mm_l = new MarkarthMilk();
            mm_l.Size = Size.Large;
            var ww_l = new WarriorWater();
            ww_l.Size = Size.Large;
            var ss_s_b = new SailorSoda();
            ss_s_b.Size = Size.Small;
            ss_s_b.Flavor = SodaFlavor.Blackberry;
            var ss_s_c = new SailorSoda();
            ss_s_c.Size = Size.Small;
            ss_s_c.Flavor = SodaFlavor.Cherry;
            var ss_s_g = new SailorSoda();
            ss_s_g.Size = Size.Small;
            ss_s_g.Flavor = SodaFlavor.Grapefruit;
            var ss_s_l = new SailorSoda();
            ss_s_l.Size = Size.Small;
            ss_s_l.Flavor = SodaFlavor.Lemon;
            var ss_s_p = new SailorSoda();
            ss_s_p.Size = Size.Small;
            ss_s_p.Flavor = SodaFlavor.Peach;
            var ss_s_w = new SailorSoda();
            ss_s_w.Size = Size.Small;
            ss_s_w.Flavor = SodaFlavor.Watermelon;
            var ss_m_b = new SailorSoda();
            ss_m_b.Size = Size.Medium;
            ss_m_b.Flavor = SodaFlavor.Blackberry;
            var ss_m_c = new SailorSoda();
            ss_m_c.Size = Size.Medium;
            ss_m_c.Flavor = SodaFlavor.Cherry;
            var ss_m_g = new SailorSoda();
            ss_m_g.Size = Size.Medium;
            ss_m_g.Flavor = SodaFlavor.Grapefruit;
            var ss_m_l = new SailorSoda();
            ss_m_l.Size = Size.Medium;
            ss_m_l.Flavor = SodaFlavor.Lemon;
            var ss_m_p = new SailorSoda();
            ss_m_p.Size = Size.Medium;
            ss_m_p.Flavor = SodaFlavor.Peach;
            var ss_m_w = new SailorSoda();
            ss_m_w.Size = Size.Medium;
            ss_m_w.Flavor = SodaFlavor.Watermelon;
            var ss_l_b = new SailorSoda();
            ss_l_b.Size = Size.Large;
            ss_l_b.Flavor = SodaFlavor.Blackberry;
            var ss_l_c = new SailorSoda();
            ss_l_c.Size = Size.Large;
            ss_l_c.Flavor = SodaFlavor.Cherry;
            var ss_l_g = new SailorSoda();
            ss_l_g.Size = Size.Large;
            ss_l_g.Flavor = SodaFlavor.Grapefruit;
            var ss_l_l = new SailorSoda();
            ss_l_l.Size = Size.Large;
            ss_l_l.Flavor = SodaFlavor.Lemon;
            var ss_l_p = new SailorSoda();
            ss_l_p.Size = Size.Large;
            ss_l_p.Flavor = SodaFlavor.Peach;
            var ss_l_w = new SailorSoda();
            ss_l_w.Size = Size.Large;
            ss_l_w.Flavor = SodaFlavor.Watermelon;
            IEnumerable<IOrderItem> items = new List<IOrderItem> { bb, dd, go, pp, ss, tt, tb, dw_s, fm_s, mo_s, vs_s, dw_m, fm_m, mo_m, vs_m, dw_l,
            fm_l, mo_l, vs_l, aj_s, cc_s, mm_s, ww_s, aj_m, cc_m, mm_m, ww_m, aj_l,
            cc_l, mm_l, ww_l, ss_s_b, ss_s_c, ss_s_g, ss_s_l, ss_s_p, ss_s_w, ss_m_b, ss_m_c, ss_m_g, ss_m_l, ss_m_p, ss_m_w,
            ss_l_b, ss_l_c, ss_l_g, ss_l_l, ss_l_p, ss_l_w};
            return items;
        }
        /// <summary>
        /// Method that filters out any item that contains the given string argument
        /// </summary>
        /// <param name="All">The database of all the movies in the list</param>
        /// <param name="search">The string that you want to search for</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> all, string search)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (search == null) return all;
            foreach(IOrderItem item in all)
            {
                if (item.ToString() != null && item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters out the items based on their category (Entree, side, or drink)
        /// </summary>
        /// <param name="all">the items that are to be filtered out</param>
        /// <param name="type">the type of item that can be added to results (Entree, side, or drink)</param>
        /// <returns>a list of the remaining items that were filtered out by their type</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> all, IEnumerable<string> type)
        {
            if (type == null || type.Count() == 0) return all;
            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in all)
            {
                if(item is Entree && type.Contains("Entree"))
                {
                    results.Add(item);
                }
                if(item is Drink && type.Contains("Drink"))
                {
                    results.Add(item);
                }
                if(item is Side && type.Contains("Side"))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters results by the amount of calories entered
        /// </summary>
        /// <param name="all">the items to be filtered out</param>
        /// <param name="min">the minimum number of calories to be filtered</param>
        /// <param name="max">the maximum number of calories to be filtered</param>
        /// <returns>the list of items left in the list</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> all, int? min, int? max)
        {
            if (min == null && max == null) return all;
            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in all)
                {
                    if(item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if(max == null)
            {
                foreach(IOrderItem item in all)
                {
                    if(item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            foreach(IOrderItem item in all)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters results by the price entered
        /// </summary>
        /// <param name="all">the items to be filtered out</param>
        /// <param name="min">the minimum price to be filtered</param>
        /// <param name="max">the maximum price to be filtered</param>
        /// <returns>the list of items left in the list</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> all, double? min, double? max)
        {
            if (min == null && max == null) return all;
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in all)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in all)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            foreach (IOrderItem item in all)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
