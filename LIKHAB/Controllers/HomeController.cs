using System.Web.Mvc;

namespace LIKHAB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // DXCOMMENT: Pass a data model for GridView

            return View("Index");
        }
    }
}