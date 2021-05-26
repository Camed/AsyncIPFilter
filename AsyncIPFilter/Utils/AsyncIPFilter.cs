using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncIPFilter.Utils
{
    public class IPFilter : IAsyncPageFilter
    {
        private readonly IConfiguration config;
        public IPFilter(IConfiguration _config)
        {
            config = _config;
        }

        public async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext pageContext)
        {
            await Task.CompletedTask;
        }
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext pageContext, PageHandlerExecutionDelegate next)
        {
            await next.Invoke();
        }
    }
}
