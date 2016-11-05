using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Elmah;

namespace Ephesto.Web
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void ErrorLog_Filtering(object sender, ExceptionFilterEventArgs e)
        {
            if (!(e.Exception.GetBaseException() is HttpException)) return;

            var ex = (HttpException) e.Exception.GetBaseException();

            if (ex.GetHttpCode() == 404)
                e.Dismiss(); // ignora o erro
        }
    }
}