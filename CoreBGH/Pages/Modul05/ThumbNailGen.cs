using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.Pages.Modul05
{
    public class ThumbNailGen
    {
        public ThumbNailGen(RequestDelegate next)
        {

        }
        public async Task Invoke(HttpContext context)
        {

        }


    }
    public static class ThumbNailGenExtensions
    {
        public static IApplicationBuilder UseThumbnailGen(IApplicationBuilder app)
        {
            return app.UseMiddleware<ThumbNailGen>();
        }
    }
}
