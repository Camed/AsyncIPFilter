using AsyncIPFilter.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncIPFilter.Pages
{
    [IPFilterAttributes]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnGet()
        {
        }
    }
}
