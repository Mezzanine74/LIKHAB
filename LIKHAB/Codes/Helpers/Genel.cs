using System;
using System.Web;

namespace LIKHAB.Codes.Helpers
{
    public class Genel
    {

        public static Int32 GetParameterFromURL(string parameter = "id")
        {
            //var helper = new UrlHelper(Url.RequestContext.RouteData.Values);
            //UrlHelper url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            //HttpContextWrapper httpContextWrapper = new HttpContextWrapper(System.Web.HttpContext.Current);
            //UrlHelper urlHelper = new UrlHelper(new RequestContext(httpContextWrapper, RouteTable.Routes.GetRouteData(httpContextWrapper)));

            var url = new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext);
            var routeValues = url.RequestContext.RouteData.Values;
            var paramName = parameter; // Is Id gelir
            var id_url = routeValues.ContainsKey(paramName) ? routeValues[paramName] : HttpContext.Current.Request.QueryString[paramName];

            return Convert.ToInt32(id_url);

        }

    }
}