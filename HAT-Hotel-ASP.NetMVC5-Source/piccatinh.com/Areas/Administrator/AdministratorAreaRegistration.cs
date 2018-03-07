using System.Web.Mvc;

namespace piccatinh.com.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Administrator_default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", controller = "HomeAdmin", id = UrlParameter.Optional }
            );
        }
    }
}