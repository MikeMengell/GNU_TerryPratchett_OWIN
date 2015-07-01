using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System;
using System.Threading.Tasks;

namespace OWIN.GNU_TerryPratchett
{
    public class GNUTerryPratchettMiddleware
    {
        private readonly RequestDelegate _next;
        
        /// <summary>
        /// Creates a default web page for new applications.
        /// </summary>
        /// <param name="next"></param>
        public GNUTerryPratchettMiddleware(RequestDelegate next)
        {
            if (next == null)
            {
                throw new ArgumentNullException("next");
            }
        
            _next = next;
        }

        /// <summary>
        /// Process an individual request.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task Invoke(HttpContext context)
        {
            HttpResponse response = context.Response;
            response.Headers.Set("X-Clacks-Overhead", "GNU Terry Pratchett");

            return _next(context);
        }

    }
    
}