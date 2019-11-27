using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WeeklyReportAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();
           // "http://localhost:4204/"
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );
            config.Routes.MapHttpRoute(
          name: "DefaultApi1",
          routeTemplate: "api/{controller}/{action}/{id}/{dcode}",
          defaults: new { id = RouteParameter.Optional }
      );

            config.Routes.MapHttpRoute(
              name: "DefaultApi3",
              routeTemplate: "api/{controller}/{action}/{id}/{dcode}/{ccode}/{scheme}",
              defaults: new { id = RouteParameter.Optional }
          );
            config.Routes.MapHttpRoute(
           name: "DefaultApi4",
           routeTemplate: "api/{controller}/{action}/{id}/{dcode}/{ccode}/{scheme}/{component}",
           defaults: new { id = RouteParameter.Optional }
       );
            config.Routes.MapHttpRoute(
            name: "DefaultApi5",
            routeTemplate: "api/{controller}/{action}/{id}/{dcode}/{ccode}",
            defaults: new { id = RouteParameter.Optional }
        );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
        //---------------------


    }
}
 
