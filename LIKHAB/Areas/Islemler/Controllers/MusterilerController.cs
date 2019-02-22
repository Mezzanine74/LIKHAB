using LIKHAB.Areas.Islemler.ViewModels;
using LIKHAB.Common;
using LIKHAB.DataLayer;
using LIKHAB.Models.db;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize(Roles = HelperClasses.RoleNames.Aktif)]
    public class MusterilerController : Controller
    {
        private LIHKAB_dbEntities db = new LIHKAB_dbEntities();

        // GET: Islemler/Musteriler
        public ActionResult Index()
        {
            var musteri = db.Musteri.Include(m => m.MusteriTemsilDurumu);
            return View("Index", musteri.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //******** Gridview *************

        // GRIDVIEW MUSTERILER
        LIKHAB.Models.db.LIHKAB_dbEntities db1 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        // GRIDVIEW MUSTERI

        public IQueryable<MusteriViewModel> getMusteriViewModel()
        {
            return db2.Musteri.Select(c => new LIKHAB.Areas.Islemler.ViewModels.MusteriViewModel
            {
                id = c.id,
                AdiSoyadi = c.AdiSoyadi,
                Eposta = c.Eposta,
                Faks = c.Faks,
                StopajdaGoster = c.MusteriTemsilDurumu.StopajdaGoster,
                TCkimlik_VergiNo = c.TCkimlik_VergiNo,
                Telefon1 = c.Telefon1,
                Telefon2 = c.Telefon2,
                TemsilDurumu = c.TemsilDurumu,
                Adress = c.Adress,
                VergiDairesi = c.VergiDairesi
            });
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialMusteri()
        {
            var model = getMusteriViewModel();

            ViewBag.TemsilDurumu = db.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteri", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriAddNew(LIKHAB.Models.db.Musteri item)
        {
            var model = getMusteriViewModel();

            var modelToAdd = new LIKHAB.Models.db.Musteri();
            if (ModelState.IsValid)
            {
                try
                {
                    modelToAdd.AdiSoyadi = item.AdiSoyadi;
                    modelToAdd.Eposta = item.Eposta;
                    modelToAdd.Faks = item.Faks;
                    modelToAdd.TemsilDurumu = item.TemsilDurumu;
                    modelToAdd.TCkimlik_VergiNo = item.TCkimlik_VergiNo;
                    modelToAdd.Telefon1 = item.Telefon1;
                    modelToAdd.Telefon2 = item.Telefon2;
                    modelToAdd.VergiDairesi = item.VergiDairesi;
                    modelToAdd.Adress = item.Adress;
                    modelToAdd.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                    modelToAdd.WhenCreated = LocalTime.GetIstanbul();

                    db2.Musteri.Add(modelToAdd);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.TemsilDurumu = db.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteri", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriUpdate(LIKHAB.Models.db.Musteri item)
        {
            var model = getMusteriViewModel();

            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = db2.Musteri.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        modelItem.AdiSoyadi = item.AdiSoyadi;
                        modelItem.Eposta = item.Eposta;
                        modelItem.Faks = item.Faks;
                        modelItem.TemsilDurumu = item.TemsilDurumu;
                        modelItem.TCkimlik_VergiNo = item.TCkimlik_VergiNo;
                        modelItem.Telefon1 = item.Telefon1;
                        modelItem.Telefon2 = item.Telefon2;
                        modelItem.VergiDairesi = item.VergiDairesi;
                        modelItem.Adress = item.Adress;
                        modelItem.WhoUpdated = UserInfo.GetAdiSoyadiOfCurrentUser();
                        modelItem.WhenUpdated = LocalTime.GetIstanbul();

                        db2.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.TemsilDurumu = db.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteri", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriDelete(System.Int32 id)
        {
            var model = getMusteriViewModel();

            if (id >= 0)
            {
                try
                {
                    var item = db2.Musteri.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        db2.Musteri.Remove(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }

            return PartialView("_GridViewPartialMusteri", model.ToList());
        }

        // VERTICAL GRID
        LIKHAB.Models.db.LIHKAB_dbEntities db3 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        [ValidateInput(false)]
        public ActionResult VerticalGridPartialMusteriSecilen(int id = 0)
        {
            var model = db3.Musteri.Where(c => c.id == id).Select(c => new VerticalGridPartialMusteriSecilenViewModel { id = c.id, AdiSoyadi = c.AdiSoyadi, TCkimlik_VergiNo = c.TCkimlik_VergiNo, MusteriTemsilDurumu = c.MusteriTemsilDurumu.Tanim });
            return PartialView("~/Areas/Islemler/Views/Musteriler/_VerticalGridPartialMusteriSecilen.cshtml", model.ToList());
        }

        // GRIDVIEW MUSTERI SEC HESAP SAYFASI
        LIKHAB.Models.db.LIHKAB_dbEntities db2 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        public IQueryable<MusteriSecViewModel> getMusteriSecViewModel()
        {
            return db2.Musteri.Select(c => new LIKHAB.Areas.Islemler.ViewModels.MusteriSecViewModel
            {
                id = c.id,
                AdiSoyadi = c.AdiSoyadi,
                Eposta = c.Eposta,
                Faks = c.Faks,
                StopajdaGoster = c.MusteriTemsilDurumu.StopajdaGoster,
                TCkimlik_VergiNo = c.TCkimlik_VergiNo,
                Telefon1 = c.Telefon1,
                Telefon2 = c.Telefon2,
                TemsilDurumu = c.TemsilDurumu,
                Adress = c.Adress,
                VergiDairesi = c.VergiDairesi
            });
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSec(bool stopaj = false)
        {
            var model = getMusteriSecViewModel();
            ViewBag.Stopaj = stopaj;
            ViewBag.TemsilDurumu = db2.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteriSec", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecAddNew(LIKHAB.Areas.Islemler.ViewModels.MusteriSecViewModel item, bool stopaj = false)
        {

            var model = getMusteriSecViewModel();

            var modelToAdd = new LIKHAB.Models.db.Musteri();
            if (ModelState.IsValid)
            {
                try
                {
                    modelToAdd.AdiSoyadi = item.AdiSoyadi;
                    modelToAdd.Eposta = item.Eposta;
                    modelToAdd.Faks = item.Faks;
                    modelToAdd.TemsilDurumu = item.TemsilDurumu;
                    modelToAdd.TCkimlik_VergiNo = item.TCkimlik_VergiNo;
                    modelToAdd.Telefon1 = item.Telefon1;
                    modelToAdd.Telefon2 = item.Telefon2;
                    modelToAdd.VergiDairesi = item.VergiDairesi;
                    modelToAdd.Adress = item.Adress;
                    modelToAdd.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                    modelToAdd.WhenCreated = LocalTime.GetIstanbul();

                    db2.Musteri.Add(modelToAdd);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            ViewBag.Stopaj = stopaj;
            ViewBag.TemsilDurumu = db2.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteriSec", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecUpdate(LIKHAB.Areas.Islemler.ViewModels.MusteriSecViewModel item, bool stopaj = false)
        {
            var model = getMusteriSecViewModel();

            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = db2.Musteri.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        modelItem.AdiSoyadi = item.AdiSoyadi;
                        modelItem.Eposta = item.Eposta;
                        modelItem.Faks = item.Faks;
                        modelItem.TemsilDurumu = item.TemsilDurumu;
                        modelItem.TCkimlik_VergiNo = item.TCkimlik_VergiNo;
                        modelItem.Telefon1 = item.Telefon1;
                        modelItem.Telefon2 = item.Telefon2;
                        modelItem.VergiDairesi = item.VergiDairesi;
                        modelItem.Adress = item.Adress;
                        modelItem.WhoUpdated = UserInfo.GetAdiSoyadiOfCurrentUser();
                        modelItem.WhenUpdated = LocalTime.GetIstanbul();

                        db2.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            ViewBag.Stopaj = stopaj;
            ViewBag.TemsilDurumu = db2.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteriSec", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecDelete(System.Int32 id, bool stopaj = false)
        {
            var model = getMusteriSecViewModel();

            if (id >= 0)
            {
                try
                {
                    var item = db2.Musteri.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        db2.Musteri.Remove(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            ViewBag.TemsilDurumu = db2.MusteriTemsilDurumu.ToList();
            ViewBag.Stopaj = stopaj;
            return PartialView("_GridViewPartialMusteriSec", model.ToList());
        }

        // GRIDVIEW MUSTERI SEC IS BILGISI SAYFASI
        LIKHAB.Models.db.LIHKAB_dbEntities db_4 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        public IQueryable<MusteriSecIsBilgilerindeViewModel> getMusteriSecIsBilgilerindeViewModel()
        {
            return db_4.Musteri.Select(c => new LIKHAB.Areas.Islemler.ViewModels.MusteriSecIsBilgilerindeViewModel
            {
                id = c.id,
                AdiSoyadi = c.AdiSoyadi,
                Eposta = c.Eposta,
                Faks = c.Faks,
                IsBilgilerindeZorunluTip = c.MusteriTemsilDurumu.IsBilgilerindeZorunluTip,
                TCkimlik_VergiNo = c.TCkimlik_VergiNo,
                Telefon1 = c.Telefon1,
                Telefon2 = c.Telefon2,
                TemsilDurumu = c.TemsilDurumu,
                VergiDairesi = c.VergiDairesi
            });

        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecIsBilgisinde(bool stopaj = false)
        {
            var model = getMusteriSecIsBilgilerindeViewModel();

            ViewBag.Stopaj = stopaj;
            ViewBag.TemsilDurumu = db_4.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteriSecIsBilgisinde", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecIsBilgisindeAddNew(LIKHAB.Models.db.Musteri item)
        {
            var model = getMusteriSecIsBilgilerindeViewModel();

            if (ModelState.IsValid)
            {
                try
                {
                    var a = new Models.db.Musteri()
                    {
                        AdiSoyadi = item.AdiSoyadi,
                        Adress = item.Adress,
                        Eposta = item.Eposta,
                        Faks = item.Faks,
                        TCkimlik_VergiNo = item.TCkimlik_VergiNo,
                        Telefon1 = item.Telefon1,
                        Telefon2 = item.Telefon2,
                        TemsilDurumu = item.TemsilDurumu,
                        VergiDairesi = item.VergiDairesi,
                        WhenCreated = LocalTime.GetIstanbul(),
                        WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser()
                    };
                    db_4.Musteri.Add(a);
                    db_4.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return PartialView("_GridViewPartialMusteriSecIsBilgisinde", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecIsBilgisindeUpdate(LIKHAB.Areas.Islemler.ViewModels.MusteriSecIsBilgilerindeViewModel item, bool stopaj = false)
        {
            var model = getMusteriSecIsBilgilerindeViewModel();

            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = db_4.Musteri.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        modelItem.AdiSoyadi = item.AdiSoyadi;
                        modelItem.Adress = item.Adress;
                        modelItem.Eposta = item.Eposta;
                        modelItem.Faks = item.Faks;
                        modelItem.TCkimlik_VergiNo = item.TCkimlik_VergiNo;
                        modelItem.Telefon1 = item.Telefon1;
                        modelItem.Telefon2 = item.Telefon2;
                        modelItem.TemsilDurumu = item.TemsilDurumu;
                        modelItem.VergiDairesi = item.VergiDairesi;
                        modelItem.Adress = item.Adress;
                        modelItem.WhenUpdated = LocalTime.GetIstanbul();
                        modelItem.WhoUpdated = UserInfo.GetAdiSoyadiOfCurrentUser();
                        db_4.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            ViewBag.Stopaj = stopaj;
            ViewBag.TemsilDurumu = db_4.MusteriTemsilDurumu.ToList();
            return PartialView("_GridViewPartialMusteriSecIsBilgisinde", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialMusteriSecIsBilgisindeDelete(System.Int32 id)
        {
            var model = getMusteriSecIsBilgilerindeViewModel();
            if (id >= 0)
            {
                try
                {
                    var item = db_4.Musteri.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        db_4.Musteri.Remove(item);
                    db_4.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialMusteriSecIsBilgisinde", model.ToList());
        }



    }
}
