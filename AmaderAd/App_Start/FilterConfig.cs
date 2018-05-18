using AmaderAd.Filters;
using AspNetSeo.Mvc;
using System.Web.Mvc;

namespace AmaderAd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
             
            //ExceptionHandlerAttribute
            filters.Add(new ExceptionHandlerAttribute());
            filters.Add(new SeoBaseTitleAttribute("Amader Ad"));
            filters.Add(new SeoBaseLinkCanonicalAttribute("http://amaderad.net/"));
        }
    }
}
