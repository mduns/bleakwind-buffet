using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Microsoft.AspNetCore.Mvc.Routing;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// The items that remain in the list after the search 
        /// </summary>
        public IEnumerable<IOrderItem> items { get; set; }
        /// <summary>
        /// The filtered search items that contain the name that you search for
        /// </summary>
        public string SearchTerms { get; set; }
        /// <summary>
        /// The type of item that you want (Entree, side, or drink)
        /// </summary>
        public string[] Categories { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? calMin, int? calMax, double? priceMin, double? priceMax )
        {
            items = Menu.FullMenu();
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            if(SearchTerms != null)
            {
                var fullItems = Menu.FullMenu();
                string[] searches = SearchTerms.Split(' ');
                items = items.Where(item => item.ToString() != null && (item.ToString().Contains(searches[0], StringComparison.InvariantCultureIgnoreCase)
                || item.Description.Contains(searches[0], StringComparison.InvariantCultureIgnoreCase)));
                for (int i = 1; i < searches.Length; i++)
                {
                    var tempItems = fullItems.Where(item => item.ToString() != null && (item.ToString().Contains(searches[i], StringComparison.InvariantCultureIgnoreCase)
                || item.Description.Contains(searches[i], StringComparison.InvariantCultureIgnoreCase)));
                    if(tempItems != null)
                    {
                        items = items.Concat(tempItems);
                    }
                }
            }
            if(Categories != null && Categories.Length != 0)
            {
                items = items.Where(item => item.Category != null && Categories.Contains(item.Category));
            }
            if (calMin != null || calMax != null)
            {
                if (calMin == null)
                {
                    items = items.Where(item => item.Calories <= calMax);
                }
                else if (calMax == null)
                {
                    items = items.Where(item => item.Calories >= calMin);
                }
                else
                {
                    items = items.Where(item => item.Calories >= calMin && item.Calories <= calMax);
                }
            }
            if (priceMin != null || priceMax != null)
            {
                if (priceMin == null)
                {
                    items = items.Where(item => item.Price <= priceMax);
                }
                else if (priceMax == null)
                {
                    items = items.Where(item => item.Price >= priceMin);
                }
                else
                {
                    items = items.Where(item => item.Price >= priceMin && item.Price <= priceMax);
                }
            }
            //items = Menu.Search(items, SearchTerms);
            //items = Menu.FilterByCategory(items, Categories);
            //items = Menu.FilterByCalories(items, calMin, calMax);
            //items = Menu.FilterByPrice(items, priceMin, priceMax);
        }
    }
}
