using LIKHAB.Areas.Islemler.ViewModels;
using LIKHAB.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize(Roles = HelperClasses.RoleNames.Patron)]
    public class IlIlceMahalleController : Controller
    {
        // GET: Islemler/IlIlceMahalle
        public ActionResult Main()
        {
            return View("Main");

        }

        LIHKAB_dbEntities db = new LIHKAB_dbEntities();

        //ILLER

        public IEnumerable<IlViewModel> GetIller()
        {
            return db.Ili.Select(c => new IlViewModel() { id = c.id, Il = c.Il, IlKatsayisi = c.IlKatsayisi });
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialIl()
        {
            var model = GetIller();
            return PartialView("_GridViewPartialIl", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlAddNew(IlViewModel item)
        {
            var model = GetIller();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                    var a = new Ili() { Il = item.Il, IlKatsayisi = item.IlKatsayisi };
                    db.Ili.Add(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialIl", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlUpdate(IlViewModel item)
        {
            var model = GetIller();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                    var a = db.Ili.FirstOrDefault(c => c.id == item.id);
                    a.Il = item.Il;
                    a.IlKatsayisi = item.IlKatsayisi;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialIl", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlDelete(System.Int32 id)
        {
            var model = GetIller();
            if (id >= 0)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                    var a = db.Ili.FirstOrDefault(c => c.id == id);
                    db.Ili.Remove(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialIl", model.ToList());
        }


        // ILCE

        public IEnumerable<IlceViewModel> GetIlceler()
        {
            return db.Ilce.Select(c => new IlceViewModel() { id = c.id, ilId = c.Il, il = c.Ili.Il, ilce = c.Ilce1 });
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialIlce()
        {
            var model = GetIlceler();
            ViewBag.Iller = db.Ili.ToList();
            return PartialView("_GridViewPartialIlce", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlceAddNew(IlceViewModel item)
        {
            var model = GetIlceler();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                    var a = new Ilce() { Il = item.ilId, Ilce1 = item.ilce };
                    db.Ilce.Add(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.Iller = db.Ili.ToList();
            return PartialView("_GridViewPartialIlce", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlceUpdate(IlceViewModel item)
        {
            var model = GetIlceler();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                    var a = db.Ilce.FirstOrDefault(c => c.id == item.id);
                    a.Ilce1 = item.ilce;
                    a.Il = item.ilId;
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.Iller = db.Ili.ToList();
            return PartialView("_GridViewPartialIlce", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIlceDelete(int id)
        {
            var model = GetIlceler();
            if (id >= 0)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                    var a = db.Ilce.FirstOrDefault(c => c.id == id);
                    db.Ilce.Remove(a);
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }

            ViewBag.Iller = db.Ili.ToList();
            return PartialView("_GridViewPartialIlce", model.ToList());
        }

        // KOY MAHALLE

        public IEnumerable<KoyMahalleViewModel> GetKoyler(int id = 0)
        {
            if (id > 0)
            {
                return db.Koy_Mahalle.Where(c => c.Ilce == id).Select(c => new KoyMahalleViewModel() { id = c.id, il = c.Ilce1.Ili.Il, ilce = c.Ilce1.Ilce1, ilceId = c.Ilce, koyMahalle = c.Koy_Mahalle1, YolKilometre = c.YolKilometre });
            }

            return db.Koy_Mahalle.Select(c => new KoyMahalleViewModel() { id = c.id, il = c.Ilce1.Ili.Il, ilce = c.Ilce1.Ilce1, ilceId = c.Ilce, koyMahalle = c.Koy_Mahalle1, YolKilometre = c.YolKilometre });

        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialKoyMahalle(int id = 0)
        {
            var model = GetKoyler(id);
            ViewBag.Ilceler = db.Ilce.ToList();
            return PartialView("_GridViewPartialKoyMahalle", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialKoyMahalleAddNew(KoyMahalleViewModel item)
        {
            var model = GetKoyler();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                    var a = new Koy_Mahalle() { Ilce = item.ilceId, Koy_Mahalle1 = item.koyMahalle, YolKilometre = item.YolKilometre };
                    db.Koy_Mahalle.Add(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.Ilceler = db.Ilce.ToList();
            return PartialView("_GridViewPartialKoyMahalle", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialKoyMahalleUpdate(KoyMahalleViewModel item)
        {
            var model = GetKoyler();
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                    var a = db.Koy_Mahalle.FirstOrDefault(c => c.id == item.id);
                    a.Ilce = item.ilceId;
                    a.Koy_Mahalle1 = item.koyMahalle;
                    a.YolKilometre = item.YolKilometre;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.Ilceler = db.Ilce.ToList();

            return PartialView("_GridViewPartialKoyMahalle", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialKoyMahalleDelete(int id)
        {
            var model = GetKoyler();
            if (id >= 0)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                    var a = db.Koy_Mahalle.FirstOrDefault(c => c.id == id);
                    db.Koy_Mahalle.Remove(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }

            ViewBag.Ilceler = db.Ilce.ToList();
            return PartialView("_GridViewPartialKoyMahalle", model.ToList());
        }
    }
}