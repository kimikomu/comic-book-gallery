using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComicBookGallery
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();	// registers all the MVC Areas in our website
            RouteConfig.RegisterRoutes(RouteTable.Routes);	// registers the routes for our website
        }
    }
}
