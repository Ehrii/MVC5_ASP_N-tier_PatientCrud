using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PatientCrud
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            var httpException = exception as HttpException;

            if (httpException != null)
            {
                int httpCode = httpException.GetHttpCode();

                if (httpCode == 505)
                {
                    // Handle 505 error
                    Response.Clear();
                    Server.ClearError();
                    Response.Redirect("/Admin/Patient/Error505");
                }
                else if (httpCode == 404)
                {
                    // Handle 404 error
                    Response.Clear();
                    Server.ClearError();
                    Response.Redirect("/Admin/Patient/Error404");
                }
            }
        }

    }
}
