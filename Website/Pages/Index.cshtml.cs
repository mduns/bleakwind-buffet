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
            items = Menu.Search(items, SearchTerms);
            items = Menu.FilterByCategory(items, Categories);
            items = Menu.FilterByCalories(items, calMin, calMax);
            items = Menu.FilterByPrice(items, priceMin, priceMax);
        }
    }
}
