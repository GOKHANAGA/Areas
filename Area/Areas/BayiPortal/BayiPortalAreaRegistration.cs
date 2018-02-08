using System.Web.Mvc;

namespace Area.Areas.BayiPortal
{
    public class BayiPortalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BayiPortal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BayiPortal_default",
                "BayiPortal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}