using System.Web;
using System.Web.Mvc;

namespace Restoran_Rezervasyon_ve_Siparis_Yonetim_Sistemi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
