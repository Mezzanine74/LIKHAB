using DevExpress.Web.Mvc;
using LIKHAB.BusinessLogic.UcretHesaplama;
using LIKHAB.Common;
using LIKHAB.DataLayer;
using LIKHAB.Models.db;
using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize(Roles = HelperClasses.RoleNames.Aktif)]
    public class UcretHesaplamaController : Controller
    {
        private LIHKAB_dbEntities db = new LIHKAB_dbEntities();

        public ActionResult Hesapla()
        {
            ViewBag.IsinCinsi = new SelectList(db.IsinCinsi, "id", "Tanim");
            ViewBag.IsinTuru = db.IsTurleri.ToList();
            ViewBag.Koyu_Mahallesi = new SelectList(db.Koy_Mahalle, "id", "Koy_Mahalle1");
            ViewBag.Musteri = new SelectList(db.Musteri, "id", "AdiSoyadi");
            //ViewBag.OdaKatsayi = "'" + db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_16_12.ToString()).ToList()[0].Parametre.ToString() + "'";
            ViewBag.OdaKatsayi = "'" + LIKHAB.BusinessLogic.Helpers.UcretAyarlari.Ucrt_16_12.ToString() + "'";
            return View("Hesapla", new LIKHAB.Areas.Islemler.ViewModels.HesaplamaViewModel()); // acikca yazmazsan unit test calismiyor
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Hesapla([Bind(Exclude = "UcretDokumu")] LIKHAB.Areas.Islemler.ViewModels.HesaplamaViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Isler eklenir
                model.ModelIsler.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                model.ModelIsler.WhenCreated = LocalTime.GetIstanbul();

                using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
                {
                    var musteriId = model.ModelIsler.Musteri;
                    var a = db.Musteri.FirstOrDefault(c => c.id == musteriId);
                    if (a != null)
                    {
                        model.MusteriTemsilDurumu = a.MusteriTemsilDurumu.Tanim;
                    }
                }

                var passModel = new LIKHAB.Models.db.Isler();
                passModel = model.ModelIsler;
                passModel.MusteriTemsilDurumu = model.MusteriTemsilDurumu;

                db.Isler.Add(passModel);
                db.SaveChanges();

                var id_is = model.ModelIsler.id;

                if (id_is > 0)
                {
                    // is parametre IS tanimlanir
                    model.ModelIsParametreleri.Is = id_is;
                    // IsPArametreleri eklenir
                    model.ModelIsParametreleri.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                    model.ModelIsParametreleri.WhenCreated = LocalTime.GetIstanbul();

                    db.IsParametreleri.Add(model.ModelIsParametreleri);
                    db.SaveChanges();

                    // Ucret Dokumunu IS e bagla
                    var ud_id = Convert.ToInt32(Session["ud_id"]);
                    var ucretDokumu = db.UcretDokumu.Where(c => c.id == ud_id).ToList()[0];
                    ucretDokumu.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                    ucretDokumu.WhenCreated = LocalTime.GetIstanbul();
                    ucretDokumu.Is = id_is;
                    db.SaveChanges();

                    // IsAsamalarini Ekle
                    var isAsamalari = new LIKHAB.Models.db.IsAsamalari() { IsId = id_is, WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser(), WhenCreated = LocalTime.GetIstanbul() };
                    db.IsAsamalari.Add(isAsamalari);
                    db.SaveChanges();

                }

                return RedirectToAction("RandevuVer", "Randevu", new { id = id_is });
            }

            ViewBag.IsinCinsi = new SelectList(db.IsinCinsi, "id", "Tanim");
            ViewBag.IsinTuru = db.IsTurleri.ToList();
            ViewBag.Koyu_Mahallesi = new SelectList(db.Koy_Mahalle, "id", "Koy_Mahalle1");
            ViewBag.Musteri = new SelectList(db.Musteri, "id", "AdiSoyadi");
            //ViewBag.OdaKatsayi = "'" + db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_16_12.ToString()).ToList()[0].Parametre.ToString() + "'";
            ViewBag.OdaKatsayi = "'" + LIKHAB.BusinessLogic.Helpers.UcretAyarlari.Ucrt_16_12.ToString() + "'";

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // VERTICAL GRID ISIN DETAYI
        [ValidateInput(false)]
        public ActionResult VerticalGridPartialIsinKucukDetayi(int id = 0)
        {
            var model = db.ViewIsinKucukDetayi.Where(c => c.id == id);
            return PartialView("_VerticalGridPartialIsinKucukDetayi", model.ToList());
        }

        LIKHAB.Models.db.LIHKAB_dbEntities db1 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        [ValidateInput(false)]
        public ActionResult VerticalGridPartialUcretDokumu(int isId = 0)
        {
            // yeni bir ucret dokumu ekle
            LIKHAB.Models.db.UcretDokumu ud = new LIKHAB.Models.db.UcretDokumu();

            db1.UcretDokumu.Add(ud);
            db1.SaveChanges();
            Session["ud_id"] = ud.id;

            IQueryable<LIKHAB.Models.db.UcretDokumu> model;
            if (isId > 0)
            {
                model = db1.UcretDokumu.Where(c => c.Is == isId);
            }
            else
            {
                model = db1.UcretDokumu.Where(c => c.id == ud.id);
            }

            return PartialView("_VerticalGridPartialUcretDokumu", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult VerticalGridPartialUcretDokumuUpdate(MVCxGridBatchUpdateValues<LIKHAB.Models.db.UcretDokumu, System.Int32> updateValues)
        {
            foreach (var record in updateValues.Insert)
            {
                if (updateValues.IsValid(record))
                    VerticalGridPartialUcretDokumuInsertRecord(record, updateValues);
            }
            foreach (var record in updateValues.Update)
            {
                if (updateValues.IsValid(record))
                    VerticalGridPartialUcretDokumuUpdateRecord(record, updateValues);
            }
            foreach (var key in updateValues.DeleteKeys)
            {
                VerticalGridPartialUcretDokumuDeleteRecord(key, updateValues);
            }

            var _id = 0;
            if (Convert.ToInt32(Session["ud_id"]) > 0)
            {
                _id = Convert.ToInt32(Session["ud_id"]);
            };
            var model = db1.UcretDokumu.Where(c => c.id == _id);
            return PartialView("_VerticalGridPartialUcretDokumu", model.ToList());
        }
        protected void VerticalGridPartialUcretDokumuInsertRecord(LIKHAB.Models.db.UcretDokumu record, MVCxGridBatchUpdateValues<LIKHAB.Models.db.UcretDokumu, System.Int32> updateValues)
        {
            var model = db1.UcretDokumu;
            try
            {
                model.Add(record);
                db1.SaveChanges();
            }
            catch (Exception e)
            {
                updateValues.SetErrorText(record, e.Message);
            }
        }
        protected void VerticalGridPartialUcretDokumuUpdateRecord(LIKHAB.Models.db.UcretDokumu record, MVCxGridBatchUpdateValues<LIKHAB.Models.db.UcretDokumu, System.Int32> updateValues)
        {
            var model = db1.UcretDokumu;

            // calculate and validate all rows
            var recordHesaplanmis = UcretDokumuHesabi.Hesapla(record);

            try
            {
                var modelItem = model.FirstOrDefault(it => it.id == recordHesaplanmis.id);
                db1.Entry(modelItem).CurrentValues.SetValues(recordHesaplanmis);
                db1.SaveChanges();
            }
            catch (Exception e)
            {
                updateValues.SetErrorText(recordHesaplanmis, e.Message);
            }
        }
        protected void VerticalGridPartialUcretDokumuDeleteRecord(System.Int32 id, MVCxGridBatchUpdateValues<LIKHAB.Models.db.UcretDokumu, System.Int32> updateValues)
        {
            var model = db1.UcretDokumu;
            try
            {
                var item = model.FirstOrDefault(it => it.id == id);
                if (item != null)
                    model.Remove(item);
                db1.SaveChanges();
            }
            catch (Exception e)
            {
                updateValues.SetErrorText(id, e.Message);
            }
        }

        LIKHAB.Models.db.LIHKAB_dbEntities db2 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        public ActionResult UcretAyarlari()
        {
            return View();
        }

        // Gridview Ucret Ayarlari

        public IQueryable<ViewModels.UcretAyarlariViewModel> getUcretAyarlariViewModel()
        {
            return db2.UcretAyarlari.Select(c => new ViewModels.UcretAyarlariViewModel { Aciklama = c.Aciklama, id = c.id, IsDetayi = c.IsDetayi, Kullan = c.Kullan, Parametre = c.Parametre, UcretKodu = c.UcretKodu });
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialUcretAyarlari()
        {
            var model = getUcretAyarlariViewModel();
            return PartialView("_GridViewPartialUcretAyarlari", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUcretAyarlariAddNew(LIKHAB.Models.db.UcretAyarlari item)
        {
            var model = getUcretAyarlariViewModel();
            var ucretAyarlari = new LIKHAB.Models.db.UcretAyarlari();
            if (ModelState.IsValid)
            {
                try
                {
                    ucretAyarlari.id = item.id;
                    ucretAyarlari.Aciklama = item.Aciklama;
                    ucretAyarlari.IsDetayi = item.IsDetayi;
                    ucretAyarlari.Kullan = item.Kullan;
                    ucretAyarlari.Parametre = item.Parametre;
                    ucretAyarlari.UcretKodu = item.UcretKodu;

                    db2.UcretAyarlari.Add(ucretAyarlari);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialUcretAyarlari", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUcretAyarlariUpdate(LIKHAB.Models.db.UcretAyarlari item)
        {
            var model = getUcretAyarlariViewModel();
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = db2.UcretAyarlari.FirstOrDefault(it => it.id == item.id);
                    if (modelItem != null)
                    {
                        modelItem.id = item.id;
                        modelItem.Aciklama = item.Aciklama;
                        modelItem.IsDetayi = item.IsDetayi;
                        modelItem.Kullan = item.Kullan;
                        modelItem.Parametre = item.Parametre;
                        modelItem.UcretKodu = item.UcretKodu;

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
            return PartialView("_GridViewPartialUcretAyarlari", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUcretAyarlariDelete(System.Int32 id)
        {
            var model = getUcretAyarlariViewModel();
            if (id >= 0)
            {
                try
                {
                    var item = db2.UcretAyarlari.FirstOrDefault(it => it.id == id);
                    if (item != null)
                        db2.UcretAyarlari.Remove(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialUcretAyarlari", model.ToList());
        }
    }
}