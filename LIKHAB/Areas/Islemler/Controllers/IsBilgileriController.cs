using LIKHAB.Areas.Islemler.ViewModels;
using LIKHAB.BusinessLogic.UcretHesaplama;
using LIKHAB.Common;
using LIKHAB.DataLayer;
using LIKHAB.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize(Roles = HelperClasses.RoleNames.Aktif)]
    public class IsBilgileriController : Controller
    {
        LIHKAB_dbEntities db = new LIHKAB_dbEntities();

        public ActionResult TalepTakip()
        {

            ViewBag.Ilceler = db.Ilce.ToList();
            //ViewBag.KoyMahalleler = db.Koy_Mahalle.Where(c => c.Ilce == 1).ToList();

            return View("TalepTakip");

        }

        [HttpPost]
        public JsonResult IsBilgileriEdit(ViewModels.IsBilgileriEditViewModel model)
        {

            try
            {
                using (LIHKAB_dbEntities db = new LIHKAB_dbEntities())
                {
                    // IS BILGILERI UPDATE
                    var isBilgileri = db.IsBilgileri.FirstOrDefault(c => c.Is == model.Is);

                    isBilgileri.FenKayitTarihi = model.FenKayitTarihi;
                    isBilgileri.AdaNo = model.AdaNo;
                    isBilgileri.ParselNo = model.ParselNo;
                    isBilgileri.Maliki = model.Maliki;
                    isBilgileri.PaftaNo = model.PaftaNo;
                    isBilgileri.Aciklama = model.Notlar;
                    isBilgileri.Cinsi = model.Cinsi;
                    isBilgileri.Ilgilenen = model.Ilgilenen;
                    isBilgileri.FaturaNo = model.FaturaNo;

                    db.SaveChanges();

                }

                using (LIHKAB_dbEntities db = new LIHKAB_dbEntities())
                {
                    // MUSTERI UPDATE
                    var musteri = db.Musteri.FirstOrDefault(c => c.AdiSoyadi == model.IsSahibi);
                    musteri.Telefon1 = model.Telefon1;
                    musteri.Telefon2 = model.Telefon2;
                    int musteriId = musteri != null ? musteri.id : 0;

                    var a = db.Isler.FirstOrDefault(c => c.id == model.Is);
                    a.Musteri = musteriId;
                    a.MusteriTemsilDurumu = musteri.MusteriTemsilDurumu.Tanim;

                    // IS KOYMAHALLE UPDATE
                    var isler = db.Isler.FirstOrDefault(c => c.id == model.Is);
                    isler.Koyu_Mahallesi = model.KoyMahalleId;
                    isler.IsinTuru = model.IsinTuru;

                    db.SaveChanges();
                }

                using (LIHKAB_dbEntities db = new LIHKAB_dbEntities())
                {
                    var isler = db.Isler.FirstOrDefault(c => c.id == model.Is);
                    var isParametreleri = isler.IsParametreleri.FirstOrDefault();
                    // yeni yuzolcumunu kaydet
                    isParametreleri.YuzOlcumu = model.Yuzolcumu;

                    if (isler != null)
                    {
                        // hesaplamayi yaptir
                        var hesapmodeli = new HesapModeli();
                        hesapmodeli.AplikasyonKrokisiSayisi = isParametreleri.AplikasyonKrokisiSayisi.HasValue ? (int)isParametreleri.AplikasyonKrokisiSayisi : 0;
                        hesapmodeli.AraziyeGidilecekmi = isParametreleri.AraziyeGidilecekmi.HasValue ? (bool)isParametreleri.AraziyeGidilecekmi : false;
                        hesapmodeli.AyniKisiyeAit = isParametreleri.AyniKisiyeAit.HasValue ? (bool)isParametreleri.AyniKisiyeAit : false;
                        hesapmodeli.BagimsizBolumSayisi = isParametreleri.BagimsizBolumSayisi.HasValue ? (int)isParametreleri.BagimsizBolumSayisi : 0;
                        hesapmodeli.BinaSayisi = isParametreleri.BinaSayisi.HasValue ? (int)isParametreleri.BinaSayisi : 0;
                        hesapmodeli.BinaTabanAlani = isParametreleri.BinaTabanAlani.HasValue ? (int)isParametreleri.BinaTabanAlani : 0;
                        hesapmodeli.B_Bolum = isParametreleri.B_Bolum.HasValue ? (int)isParametreleri.B_Bolum : 0;
                        hesapmodeli.Ik = isler.Koy_Mahalle.Ilce1.Ili.IlKatsayisi;
                        hesapmodeli.InsaatAlani = isParametreleri.InsaatAlani.HasValue ? (decimal)isParametreleri.InsaatAlani : 0;
                        hesapmodeli.IsinCinsi = isler.IsinCinsi;
                        hesapmodeli.IsTuru = model.IsinTuru;
                        hesapmodeli.KatSayisi = isParametreleri.KatSayisi.HasValue ? (int)isParametreleri.KatSayisi : 0;
                        hesapmodeli.NoktaSayisi = isParametreleri.NoktaSayisi.HasValue ? (int)isParametreleri.NoktaSayisi : 0;
                        hesapmodeli.OdaBirimFiyatlariniKullan = isParametreleri.OdaBirimFiyatlariniKullan.HasValue ? (bool)isParametreleri.OdaBirimFiyatlariniKullan : false;
                        hesapmodeli.OdaKatsayi = isParametreleri.OdaKatsayi.HasValue ? (decimal)isParametreleri.OdaKatsayi : 0;
                        hesapmodeli.ParselAlani = isParametreleri.ParselAlani.HasValue ? (decimal)isParametreleri.ParselAlani : 0;
                        hesapmodeli.ParselSayisi = isParametreleri.ParselSayisi.HasValue ? (int)isParametreleri.ParselSayisi : 0;
                        hesapmodeli.Yuzde50CarpanUygula = isParametreleri.Yuzde50CarpanUygula.HasValue ? (bool)isParametreleri.Yuzde50CarpanUygula : false;
                        hesapmodeli.YuzOlcumu = model.Yuzolcumu;

                        var u = new UcretDokumuHesabi();

                        // hesapsonucu
                        var hesapSonucu = u.HesapSonucunuAl(hesapmodeli);

                        // yakitFiyatini al
                        var yakitFiyati = LIKHAB.BusinessLogic.Helpers.UcretAyarlari.Ucrt_20_01;

                        // yol ucretini hesaplat --burada elle girilme sansi yok. hesapJs de bu imkan var
                        var yolKilometre = isler.Koy_Mahalle.YolKilometre;
                        var yolUcreti = Math.Round((decimal)0.15 * yolKilometre * yakitFiyati, 2, MidpointRounding.AwayFromZero);

                        var ucretDokumu = db.UcretDokumu.FirstOrDefault(c => c.Is == model.Is);
                        ucretDokumu.GenelToplam = hesapSonucu;
                        ucretDokumu.YolUcreti = yolUcreti;

                        ucretDokumu = UcretDokumuHesabi.Hesapla(ucretDokumu);

                        db.SaveChanges();
                    }

                }

                return Json(new { result = "updated" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {

                return Json(new { result = "error" }, JsonRequestBehavior.AllowGet);
            }

            //}

        }

        // GET: Islemler/IsBilgileri
        public ActionResult IsBilgileriniGir(int id = 0)
        {
            var yilCurrent = LocalTime.GetIstanbul().Year;
            var model = (from C in db.Isler
                         join D in db.IsParametreleri on C.id equals D.Is
                         join K in db.Koy_Mahalle on C.Koyu_Mahallesi equals K.id
                         join W in db.ViewFenKayitSonrakiNumara.Where(c => c.Yil == yilCurrent) on K.Ilce equals W.IlceId
                         where C.id == id
                         select new IsBilgileriViewModel
                         {
                             Is = id,
                             IsinCinsi = C.IsinCinsi1.Tanim,
                             Ili = C.Koy_Mahalle.Ilce1.Ili.Il,
                             Ilcesi = C.Koy_Mahalle.Ilce1.Ilce1,
                             KoyMahalle = C.Koy_Mahalle.Koy_Mahalle1,
                             IsSahibi = C.Musteri1.AdiSoyadi,
                             IlKatsayi = C.Koy_Mahalle.Ilce1.Ili.IlKatsayisi.ToString(),
                             Maliki = C.Musteri1.MusteriTemsilDurumu.IsBilgilerindeZorunluTip ? C.Musteri1.AdiSoyadi : null,
                             FenKayitNo = C.IsinCinsi1.FenKayitNoSifirMi ? 0 : (int)W.VerilecekFenKayitNo,
                             Yuzolcumu = D.YuzOlcumu.HasValue ? (decimal)D.YuzOlcumu : (decimal)0
                         }).ToList();

            return View("IsBilgileriniGir", model.Count() > 0 ? model[0] : new IsBilgileriViewModel());
        }

        [HttpPost]
        public ActionResult IsBilgileriniGir(IsBilgileriViewModel model)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Validmi = "Evet";

                using (LIHKAB_dbEntities db = new LIHKAB_dbEntities())
                {
                    var isBilgileri = new IsBilgileri()
                    {
                        Is = model.Is,
                        Yili = LocalTime.GetIstanbul().Year,
                        FenKayitNo = model.FenKayitNo,
                        FenKayitTarihi = model.FenKayitTarihi,
                        PaftaNo = model.PaftaNo,
                        AdaNo = model.AdaNo,
                        ParselNo = model.ParselNo,
                        Maliki = model.Maliki,
                        Aciklama = model.Aciklama,
                        Cinsi = model.Cinsi,
                        Ilgilenen = model.Ilgilenen,
                        FaturaNo = model.FaturaNo,
                        WhenCreated = LocalTime.GetIstanbul(),
                        WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser()
                    };

                    db.IsBilgileri.Attach(isBilgileri);
                    db.IsBilgileri.Add(isBilgileri);
                    db.SaveChanges();
                    db.Dispose();
                }

                using (var db = new LIHKAB_dbEntities())
                {
                    // yuzolcumunu update et
                    var isParametreleri = db.IsParametreleri.First(c => c.Is == model.Is);
                    if (!isParametreleri.YuzOlcumu.HasValue)
                        isParametreleri.YuzOlcumu = model.Yuzolcumu;
                    db.SaveChanges();
                }

                return Redirect(Url.Content("~/"));
            }

            ViewBag.Validmi = "Hayir";
            return View(model);
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartialTalepTakip(string ilce = null)
        {
            var model = (from A in db.IsBilgileri
                         join C in db.Isler on A.Is equals C.id
                         join D in db.IsParametreleri on C.id equals D.Is
                         join K in db.Koy_Mahalle on C.Koyu_Mahallesi equals K.id
                         join L in db.IsAsamalari on C.id equals L.IsId
                         where K.Ilce1.Ilce1 == ilce
                         select new IsBilgileriViewModel
                         {
                             id = A.id,
                             Is = C.id,
                             Yili = A.Yili,
                             FenKayitNo = A.FenKayitNo,
                             FenKayitTarihi = A.FenKayitTarihi,
                             PaftaNo = A.PaftaNo,
                             AdaNo = A.AdaNo,
                             ParselNo = A.ParselNo,
                             Maliki = C.Musteri1.AdiSoyadi,
                             Aciklama = A.Aciklama,
                             Cinsi = A.Cinsi,
                             IsKapandi = L.IsKapandi,
                             IsinCinsi = C.IsinCinsi1.Tanim,
                             Ili = C.Koy_Mahalle.Ilce1.Ili.Il,
                             Ilcesi = C.Koy_Mahalle.Ilce1.Ilce1,
                             KoyMahalle = C.Koy_Mahalle.Koy_Mahalle1,
                             IsSahibi = C.Musteri1.AdiSoyadi,
                             IlKatsayi = C.Koy_Mahalle.Ilce1.Ili.IlKatsayisi.ToString(),
                             Yuzolcumu = D.YuzOlcumu.HasValue ? (decimal)D.YuzOlcumu : (decimal)0
                         }).ToList();

            var ilceler = db.Ilce.Select(c => new { c.Ilce1 }).ToList();

            var list = new List<string>();

            foreach (var item in ilceler)
            {
                list.Add(item.Ilce1);
            }

            ViewBag.Ilceler = list;
            ViewBag.SecilmisIlce = ilceler;

            return PartialView("_GridViewPartialTalepTakip", model);
        }

        // IS ASAMALARI
        [ValidateInput(false)]
        public ActionResult GridViewPartialIsAsamalari(int id = 0)
        {
            var model = db.View_IsAsamalari.Where(c => c.IsId == id);
            return PartialView("_GridViewPartialIsAsamalari", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIsAsamalariAddNew(IsAsamalariViewModel item)
        {
            var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialIsAsamalari", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIsAsamalariUpdate(IsAsamalariViewModel item, int id, IsAsamalariParametreleri actionName, string actionValue)
        {
            var model = db.View_IsAsamalari.Where(c => c.IsId == id);
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model

                    // Fatura
                    if (actionName == IsAsamalariParametreleri.Fatura)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.Fatura != b)
                        {
                            isAsamalari.Fatura = b;
                            isAsamalari.FaturaWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.FaturaWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.FaturaWhen = b;
                    }

                    // Randevu

                    // Olcum
                    if (actionName == IsAsamalariParametreleri.Olcum)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.Olcum != b)
                        {
                            isAsamalari.Olcum = b;
                            isAsamalari.OlcumWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.OlcumWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.OlcumWhen = b;
                    }

                    // Kontrol
                    if (actionName == IsAsamalariParametreleri.Kontrol)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.Kontrol != b)
                        {
                            isAsamalari.Kontrol = b;
                            isAsamalari.KontrolWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.KontrolWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.KontrolWhen = b;
                    }

                    // BeldEvrGeldi

                    if (actionName == IsAsamalariParametreleri.BeldEvrGeldi)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.BeldEvrGeldi != b)
                        {
                            isAsamalari.BeldEvrGeldi = b;
                            isAsamalari.BeldEvrGeldiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.BeldEvrGeldiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.BeldEvrGeldiWhen = b;
                    }

                    // BeldEvrGitti
                    if (actionName == IsAsamalariParametreleri.BeldEvrGitti)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.BeldEvrGitti != b)
                        {
                            isAsamalari.BeldEvrGitti = b;
                            isAsamalari.BeldEvrGittiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.BeldEvrGittiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.BeldEvrGittiWhen = b;
                    }

                    // KadEvrGeldi
                    if (actionName == IsAsamalariParametreleri.KadEvrGeldi)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        bool b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.KadEvrGeldi != b)
                        {
                            isAsamalari.KadEvrGeldi = b;
                            isAsamalari.KadEvrGeldiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.KadEvrGeldiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.KadEvrGeldiWhen = b;
                    }

                    // KadEvrGitti
                    if (actionName == IsAsamalariParametreleri.KadEvrGitti)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.KadEvrGitti != b)
                        {
                            isAsamalari.KadEvrGitti = b;
                            isAsamalari.KadEvrGittiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.KadEvrGittiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.KadEvrGittiWhen = b;
                    }


                    // ProjeYapildi
                    if (actionName == IsAsamalariParametreleri.ProjeYapildi)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.ProjeYapildi != b)
                        {
                            isAsamalari.ProjeYapildi = b;
                            isAsamalari.ProjeYapildiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.ProjeYapildiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.ProjeYapildiWhen = b;
                    }

                    // OdemeAlindi
                    if (actionName == IsAsamalariParametreleri.OdemeAlindi)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.OdemeAlindi != b)
                        {
                            isAsamalari.OdemeAlindi = b;
                            isAsamalari.OdemeAlindiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.OdemeAlindiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.OdemeAlindiWhen = b;
                    }

                    // IsKapandi
                    if (actionName == IsAsamalariParametreleri.IsKapandi)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.IsKapandi != b)
                        {
                            isAsamalari.IsKapandi = b;
                            isAsamalari.IsKapandiWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.IsKapandiWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.IsKapandiWhen = b;
                    }

                    // MusteriyiBilgilendir
                    if (actionName == IsAsamalariParametreleri.MusteriyiBilgilendir)
                    {
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        var b = Convert.ToBoolean(actionValue);

                        if (isAsamalari.MusteriyiBilgilendir != b)
                        {
                            isAsamalari.MusteriyiBilgilendir = b;
                            isAsamalari.MusteriyiBilgilendirWhen = b == true ? LocalTime.GetIstanbul() : (DateTime?)null;
                        }
                    }

                    if (actionName == IsAsamalariParametreleri.MusteriyiBilgilendirWhen)
                    {
                        var b = Convert.ToDateTime(actionValue);
                        var isAsamalari = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        isAsamalari.MusteriyiBilgilendirWhen = b;
                    }

                    if (db.SaveChanges() > 0)
                    {
                        // IsKapandiyi randevu etiketlerine isle
                        if (actionName == IsAsamalariParametreleri.IsKapandi)
                        {
                            int etiketisKapandi = LIKHAB.BusinessLogic.Helpers.Etiketler.RandevuEtiketListesi.FirstOrDefault(c => c.DisplayName == LIKHAB.BusinessLogic.Helpers.Etiketler.IsKapandi).Id;
                            int etiketisYapilmadi = LIKHAB.BusinessLogic.Helpers.Etiketler.RandevuEtiketListesi.FirstOrDefault(c => c.DisplayName == LIKHAB.BusinessLogic.Helpers.Etiketler.IsYapilmadi).Id;

                            if (Convert.ToBoolean(actionValue))
                            {
                                // isi kapat
                                LIKHAB.BusinessLogic.Helpers.Randevu.EtiketDegistirbyIsId(etiketisKapandi, id);
                            }
                            else
                            {
                                // geri al, isi yapilmadi
                                LIKHAB.BusinessLogic.Helpers.Randevu.EtiketDegistirbyIsId(etiketisYapilmadi, id);
                            }
                        }
                    };

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialIsAsamalari", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialIsAsamalariDelete(int id)
        {
            var model = new object[0];
            if (id >= 0)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialIsAsamalari", model);
        }

        // CALBACK PANEL EDIT
        public ActionResult CallbackPanelPartialIsBilgileriEdit(int isId = 0)
        {
            var model = (from C in db.Isler
                         join D in db.IsParametreleri on C.id equals D.Is
                         join K in db.Koy_Mahalle on C.Koyu_Mahallesi equals K.id
                         join L in db.IsBilgileri on C.id equals L.Is
                         join M in db.UcretDokumu on C.id equals M.Is
                         where C.id == isId
                         select new IsBilgileriEditViewModel
                         {
                             id = L.id,
                             Is = L.Is,
                             FenKayitNo = L.FenKayitNo,
                             FenKayitTarihi = L.FenKayitTarihi,
                             AdaNo = L.AdaNo,
                             ParselNo = L.ParselNo,
                             Yuzolcumu = D.YuzOlcumu.HasValue ? (decimal)D.YuzOlcumu : (decimal)0,
                             PaftaNo = L.PaftaNo,
                             Maliki = L.Maliki,
                             IsSahibi = C.Musteri1.AdiSoyadi,
                             Telefon1 = C.Musteri1.Telefon1,
                             Telefon2 = C.Musteri1.Telefon2,
                             Cinsi = L.Cinsi,
                             IsinTuru = C.IsinTuru.HasValue ? (int)C.IsinTuru : 0,
                             Ilgilenen = L.Ilgilenen,
                             Notlar = L.Aciklama,
                             FaturaNo = L.FaturaNo,
                             UcretToplam = M.GenelToplam.HasValue ? (decimal)M.GenelToplam : 0,
                             Ili = C.Koy_Mahalle.Ilce1.Ili.Il,
                             Ilcesi = C.Koy_Mahalle.Ilce1.Ilce1,
                             KoyMahalle = C.Koy_Mahalle.Koy_Mahalle1,
                             IlcesiId = C.Koy_Mahalle.Ilce1.id,
                             KoyMahalleId = C.Koyu_Mahallesi,
                             Enlem = "",
                             Boylam = "",
                             Katsayi = K.Ilce1.Ili.IlKatsayisi,
                             Yol = K.YolKilometre,
                             FaturaAlinanNetUcret = M.NetAlinan.HasValue ? (decimal)M.NetAlinan : 0,
                             TahsilatUcreti = M.Toplam.HasValue ? (decimal)M.Toplam : 0,
                             Stopaj = C.Stopaj.HasValue ? C.Stopaj : false
                         }).ToList();

            //System.Threading.Thread.Sleep(500);

            ViewBag.IsinTuru = db.IsTurleri.ToList();
            return PartialView("_CallbackPanelPartialIsBilgileriEdit", model.ToList().Count() > 0 ? model.ToList()[0] : null);
        }
    }
}

public enum IsAsamalariParametreleri
{
    Fatura,
    FaturaWhen,
    Randevu,
    RandevuWhen,
    Olcum,
    OlcumWhen,
    Kontrol,
    KontrolWhen,
    BeldEvrGeldi,
    BeldEvrGeldiWhen,
    BeldEvrGitti,
    BeldEvrGittiWhen,
    KadEvrGeldi,
    KadEvrGeldiWhen,
    KadEvrGitti,
    KadEvrGittiWhen,
    ProjeYapildi,
    ProjeYapildiWhen,
    OdemeAlindi,
    OdemeAlindiWhen,
    IsKapandi,
    IsKapandiWhen,
    MusteriyiBilgilendir,
    MusteriyiBilgilendirWhen,
}