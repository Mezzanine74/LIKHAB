using LIKHAB.BusinessLogic.Helpers;
using LIKHAB.BusinessLogic.UcretHesaplama;
using LIKHAB.Models.db;
using LIKHAB.Services.Email;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize]
    public class JSONController : Controller
    {
        private LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

        public JSONController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        #region JsonResults
        public JsonResult DDLIsinCinsi()
        {
            var _result = db.IsinCinsi.ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DDLIli()
        {
            var _result = db.Ili.ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DDLIlcesi(int id = 0)
        {
            var _result = db.Ilce.Where(c => c.Il == id).ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DDLKoyu(int id = 0)
        {
            var _result = db.Koy_Mahalle.Where(c => c.Ilce == id).ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DDLKoyuSecilen(int id = 0)
        {
            var _result = db.Koy_Mahalle.Where(c => c.id == id).ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UcretAyarlari()
        {
            var _result = db.UcretAyarlari.ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Randevular(int id = 0)
        {
            var _result = db.Randevu.Where(c => c.Is == id).ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MusteriTemsilStopaj(int id = 0)
        {
            var _result = db.Musteri.Where(c => c.id == id).Select(c => new { c.id, c.MusteriTemsilDurumu.StopajdaGoster }).ToList();

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult HesapSonucunuAl(HesapModeli model)
        {

            var hesap = new UcretDokumuHesabi();

            var _result = hesap.HesapSonucunuAl(model);

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public class UcretHesapReturn
        {
            public decimal Sonuc { get; set; }
            public decimal YakitFiyati { get; set; }
        }

        [HttpPost]
        public JsonResult UcretHesapla(HesapModeli model)
        {

            var u = new UcretDokumuHesabi();

            var _result = new UcretHesapReturn()
            {
                Sonuc = u.HesapSonucunuAl(model),
                YakitFiyati = LIKHAB.BusinessLogic.Helpers.UcretAyarlari.Ucrt_20_01
            };

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult NotificationSendEmailAway(EmailNotificationType _type, int id, int isId = 0)
        {
            var _result = false;
            _result = LIKHAB.Services.Email.SendEmail.SendAway("body gonder", _type, id, isId);

            if (_result)
            {
                if (_type == EmailNotificationType.RandevuOnayTalebiGonder)
                {
                    using (var db = new LIHKAB_dbEntities())
                    {
                        var a = db.IsAsamalari.FirstOrDefault(c => c.IsId == isId);
                        if (a != null)
                        {
                            a.OnayaGidisZamani = LIKHAB.Common.LocalTime.GetIstanbul();
                            db.SaveChanges();
                        }

                        // randevu statusu 'Onay Bekleniyor'a donecek
                        //var etiketler = new Etiketler();

                        int etiketId = Etiketler.RandevuEtiketListesi.FirstOrDefault(c => c.DisplayName == Etiketler.OnayBekliyor).Id;
                        LIKHAB.BusinessLogic.Helpers.Randevu.EtiketDegistirbyIsId(etiketId, isId);

                        db.Dispose();
                    }
                }
            }

            return Json(_result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RandevuVeIlintiliBilgileriSil(int id)
        {
            bool _return = false;

            int randevuId = id;

            int isId = 0;

            var randevu = db.Randevu.FirstOrDefault(c => c.id == randevuId);

            if (randevu != null)
            {
                isId = randevu.Is;

                _return = IsBilgileriniSil(isId);
            }

            return Json(_return, JsonRequestBehavior.AllowGet);
        }

        public class IsSilinmeSonucu
        {
            public bool basari { get; set; }
            public string baslik { get; set; }
            public string aciklama { get; set; }
        }

        public JsonResult IsIleIlintiliBilgileriSilJSON(int id)
        {

            IsSilinmeSonucu _return = new IsSilinmeSonucu() { basari = false, baslik = "-", aciklama = "-" };

            // mevcut degilse
            if (LIKHAB.BusinessLogic.Helpers.IsBilgileri.IsMevcutmu(id) != true)
            {
                _return.basari = false;
                _return.baslik = "Hata";
                _return.aciklama = "Silinemedi. Boyle bir is mevcut degil.";

                return Json(_return, JsonRequestBehavior.AllowGet);
            }

            // silmeyi dene
            _return.basari = IsBilgileriniSil(id);

            if (_return.basari)
            {
                _return.baslik = "Silindi";
                _return.aciklama = "Basariyla silindi";

                return Json(_return, JsonRequestBehavior.AllowGet);
            }

            _return.basari = false;
            _return.aciklama = "Silinemedi.";

            return Json(_return, JsonRequestBehavior.AllowGet);
        }

        public bool IsBilgileriniSil(int isId)
        {
            bool _return = false;
            using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
            {
                var isParametreleri = db.IsParametreleri.FirstOrDefault(c => c.Is == isId);
                var _is = db.Isler.FirstOrDefault(c => c.id == isId);
                var _randevu = db.Randevu.FirstOrDefault(c => c.Is == isId);

                if (isParametreleri != null)
                {
                    db.IsParametreleri.Remove(isParametreleri);
                }

                if (_is != null)
                {
                    db.Isler.Remove(_is);
                }

                if (_randevu != null)
                {
                    db.Randevu.Remove(_randevu);
                }

                LIKHAB.Services.Email.SendEmail.SendAway("body", LIKHAB.Services.Email.EmailNotificationType.IsBilgileriSilimiGeriBildirimi, 0, isId);

                db.SaveChanges();
                db.Dispose();
            }

            using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
            {
                var _is = db.Isler.FirstOrDefault(c => c.id == isId);

                if (_is == null)
                {
                    _return = true;
                }

                db.Dispose();
            }

            return _return;

        }

        public JsonResult RandevusuzOnaylaJSON(int id)
        {
            bool _return = false;

            using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
            {
                var b = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                if (b != null)
                {
                    b.Onaylanmis = true;
                    b.OnayZamani = LIKHAB.Common.LocalTime.GetIstanbul();
                    db.SaveChanges();

                    SendEmail.SendAway("body", EmailNotificationType.RandevuOnayiniGeriBildir, 0, id);

                    _return = true;

                    db.Dispose();
                }
            }

            return Json(_return, JsonRequestBehavior.AllowGet);

        }


        public class RandevuOnayValidation
        {
            public bool hata { get; set; }
            public string message { get; set; }
        }

        public RandevuOnayValidation RandevuOnayValidate(int id)
        {
            RandevuOnayValidation validation = new RandevuOnayValidation() { hata = false, message = "hata yok" };

            var a = LIKHAB.BusinessLogic.Helpers.Randevu.GetRandevuByRandevuId(id);
            int isId = a == null ? 0 : a.Is;

            // onaya gonderilmemis ise edit ve delete kapali
            if (!LIKHAB.BusinessLogic.Helpers.Randevu.OnayaGittiMi(isId))
            {
                validation.hata = true;
                validation.message = "Henuz onaya gonderilmedigi icin uzerinde islem yapilamaz.";
                return validation;
            }

            // is bilgileri girilmis ise edit ve delete kapali
            if (LIKHAB.BusinessLogic.Helpers.IsBilgileri.IsBilgileriMevcutmu(isId))
            {
                validation.hata = true;
                validation.message = "Is Bilgileri girildigi icin uzerinde islem yapilamaz.";
                return validation;
            }

            return validation;

        }

        public JsonResult RandevuOnayValidateJSON(int id)
        {
            return Json(RandevuOnayValidate(id), JsonRequestBehavior.AllowGet);

        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}