using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Site.HtmlHelpers
{
    public static class VersionHtmlHelper
    {
        public static IHtmlString GetVersion(this HtmlHelper html)
        {
            var assembly = typeof(MvcApplication).Assembly;

            var attribute = assembly.GetCustomAttributes<AssemblyInformationalVersionAttribute>()
                                    .FirstOrDefault();

            var version = attribute?.InformationalVersion ?? assembly.GetName().Version.ToString();

            return new MvcHtmlString(version);
        }
    }
}