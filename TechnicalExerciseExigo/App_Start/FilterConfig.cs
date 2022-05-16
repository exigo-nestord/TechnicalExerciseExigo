using System.Web;
using System.Web.Mvc;

namespace TechnicalExerciseExigo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
