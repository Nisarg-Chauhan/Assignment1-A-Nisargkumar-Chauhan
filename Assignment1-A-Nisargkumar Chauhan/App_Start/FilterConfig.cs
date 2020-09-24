using System.Web;
using System.Web.Mvc;

namespace Assignment1_A_Nisargkumar_Chauhan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
