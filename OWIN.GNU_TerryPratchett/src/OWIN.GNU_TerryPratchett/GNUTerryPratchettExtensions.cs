using Microsoft.AspNet.Builder;
using System;

namespace OWIN.GNU_TerryPratchett
{
    /// <summary>
    /// IApplicationBuilder extensions for the GNUTerryPratchettExtensions.
    /// </summary>
    public static class GNUTerryPratchettExtensions
    {
        /// <summary>
        /// Adds the GNUTerryPratchettMiddleware to the pipeline with the given options.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseGNUTerryPratchett(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }

            return builder.Use(next => new GNUTerryPratchettMiddleware(next).Invoke);
        }
    }
}