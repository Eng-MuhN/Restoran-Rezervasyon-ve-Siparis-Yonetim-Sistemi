using System.Web;
using System.Web.Mvc;

namespace Restoran_Rezervasyon_Ve_Siparis_Yonetim_Sistemi_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
