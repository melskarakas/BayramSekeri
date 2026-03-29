using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BayramSekeri
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            /// Diğer başlangıç kodları buraya eklenebilir
            // Örneğin, Dependency Injection yapılandırması, filtreler, vb.
            // Örnek: Dependency Injection yapılandırması/
            /**************************************************************/
        }
    }
}
