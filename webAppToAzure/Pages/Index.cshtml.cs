using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webAppToAzure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly myDbContext context;
        public List<City> Cities { get; set; }

        public IndexModel(ILogger<IndexModel> logger, myDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public void OnGet()
        {
            Cities = context.Cities.ToList();
        }
    }
}
