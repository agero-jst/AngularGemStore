using System.Globalization;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace AngularGemStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            ConfigureJson();

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(defaults: new { id = RouteParameter.Optional }, name: "DefaultApi", routeTemplate: "api/{controller}/{id}");
        }

        private static void ConfigureJson()
        {
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
            json.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            json.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            json.SerializerSettings.Culture = new CultureInfo("se-SE");
        }
    }
}
