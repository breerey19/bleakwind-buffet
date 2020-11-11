using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> orderItems { get; set; }



        public string SearchTerms { get; set; }

        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Category = Request.Query["Category"];
            orderItems = Menu.FullMenu();
            orderItems = Menu.Search(orderItems, SearchTerms);
            orderItems = Menu.FilterByCategory(orderItems, Category);
            //Price = double.Parse(Request.Query["Price"]);
        }

        /// <summary>
        /// The filtered MPAA Ratings
        /// </summary>
        public string[] Category { get; set; }
    }
}
