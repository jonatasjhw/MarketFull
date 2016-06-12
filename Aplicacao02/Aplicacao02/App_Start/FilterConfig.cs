using System.Web;
using System.Web.Mvc;

namespace Aplicacao02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // Aqui eu bloqueio todos os acessos não autorizados!
          //  filters.Add(new AuthorizeAttribute());
        }
    }
}
