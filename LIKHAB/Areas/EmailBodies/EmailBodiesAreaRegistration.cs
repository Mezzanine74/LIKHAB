using System.Web.Mvc;

namespace LIKHAB.Areas.EmailBodies
{
    public class EmailBodiesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "EmailBodies";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "EmailBodies_default",
                "EmailBodies/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}