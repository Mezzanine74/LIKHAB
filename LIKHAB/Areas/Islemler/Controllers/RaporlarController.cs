using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize]
    public class RaporlarController : Controller
    {
        // GET: Islemler/Raporlar
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult SozlesmeRaporu()
        {
            return View();
        }

        public ActionResult TeslimSenedi()
        {
            return View();
        }

    }
}