using System.Web;
using System.Web.Mvc;

namespace BaiTap4_61133848
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
