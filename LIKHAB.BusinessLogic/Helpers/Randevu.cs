using LIKHAB.DataLayer.DBContext;
using System;
using System.Linq;

namespace LIKHAB.BusinessLogic.Helpers
{
    public partial class Randevu
    {
        private static LikhabDBContext _db;

        public Randevu()
        {
            _db = new LikhabDBContext();
        }

        public static bool EtiketDegistirbyIsId(int etiketId, int isId)
        {
            Etiketler etiketler = new Etiketler();
            var randevu = _db.Randevus.FirstOrDefault(c => c.Is == isId);
            if (randevu != null)
            {
                randevu.Label = etiketId;
                if (_db.SaveChanges() > 0) return true; ;
            }

            return false;
        }

        public static bool OnayaGittiMi(int isId)
        {
            var a = _db.IsAsamalaris.FirstOrDefault(c => c.IsId == isId);

            if (a != null)
            {
                if (a.OnayaGidisZamani.HasValue)
                {
                    return true;
                }
            }

            return false;
        }

        public static RandevuGirisValidation RandevuGirilebilirMi(int id)
        {
            RandevuGirisValidation _return = new RandevuGirisValidation() { Hata = false, HataMesaji = "hata yok" };

            // isId mevcut mu?
            if (IsBilgileri.IsMevcutmu(id) != true)
            {
                _return.Hata = true;
                _return.HataMesaji = "(" + id.ToString() + ")" + " numarali Is tanimli degil. Randevu girilemez.";
                return _return;
            }

            // randevu mevcut mu
            if (IsIdValidveRandevuYok(id) != true)
            {
                _return.Hata = true;
                _return.HataMesaji = "(" + id.ToString() + ")" + " numarali Is isin randevu tanimlanmis. Randevu girilemez.";
                return _return;
            }

            return _return;
        }

        public static bool IsIdValidveRandevuYok(int isId)
        {
            var a = _db.Islers.FirstOrDefault(c => c.Id == isId);

            if (a != null)
            {
                var b = _db.Randevus.FirstOrDefault(c => c.Is == a.Id);

                if (b == null)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool RandevuIleIsUyusuyorMu(int randevuId, int isId)
        {
            var a = _db.Randevus.FirstOrDefault(c => c.Id == randevuId && c.Is == isId);
            if (a != null)
                return true;

            return false;
        }

        public static LIKHAB.DataLayer.Models.Randevu GetRandevuByIsId(int id)
        {

            var A = _db.Randevus.Where(c => c.Is == id);

            if (A.ToList().Count() > 0)
            {
                return A.ToList()[0];
            }

            return null;
        }

        public static LIKHAB.DataLayer.Models.Randevu GetRandevuByRandevuId(int id)
        {

            var A = _db.Randevus.Where(c => c.Id == id);

            if (A.ToList().Count() > 0)
            {
                return A.ToList()[0];
            }

            return null;
        }

        public const int BeklemeToleransi = 5; // saati refere edecek

        public static double RandevuBiletiKalanToplamSaniye(int isId)
        {
            using (var db = new LikhabDBContext())
            {
                var a = db.IsAsamalaris.FirstOrDefault(c => c.IsId == isId);
                if (a != null)
                {
                    if (a.OnayZamani.HasValue) // onaylanmis ise
                    {
                        var onayZamani = (DateTime)a.OnayZamani;

                        return onayZamani.AddHours(BeklemeToleransi).Subtract(LIKHAB.Common.LocalTime.GetIstanbul()).TotalSeconds;
                    }
                }
            }

            return -1; // kalan saniyeyi negatif yap
        }

        public static GirisHatalari RandevuHatalari(int isId)
        {
            // variables
            GirisHatalari _return = new GirisHatalari() { HataVarmi = false, HataMesaji = "hata yok" };

            string isiAcanKisi = "",
                mevcutKullanici = LIKHAB.DataLayer.UserInfo.GetAdiSoyadiOfCurrentUser();
            bool isMevcutMu = Helpers.IsBilgileri.IsMevcutmu(isId);

            // ****************

            // Isi acan kisiyi al
            using (var db = new LikhabDBContext())
            {
                var a = db.Islers.FirstOrDefault(c => c.Id == isId);

                if (a != null)
                {
                    isiAcanKisi = a.WhoCreated;
                }
            }
            // **************

            // H A T A L A R

            // bu numara ile is tanimli mi
            if (!isMevcutMu)
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Bu numara ile bir is tanimli degil. Randevu olusturulamaz.";
                return _return;
            }

            // ayniKullanicilarMi > isi acan kisi ile mevcut kullanici ayni mi
            if (isiAcanKisi != mevcutKullanici && isMevcutMu)
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Isi " + isiAcanKisi + " baslattigi icin Randevuyu ancak o verebilir.";
                return _return;
            }

            return _return;
        }

        public static GirisHatalari RandevuOnayHatalari(int isId)
        {
            // variables
            GirisHatalari _return = new GirisHatalari() { HataVarmi = false, HataMesaji = "hata yok" };

            bool isMevcutMu = IsBilgileri.IsMevcutmu(isId);

            // *******

            // H A T A L A R

            // bu numara ile is tanimli mi
            if (!isMevcutMu && isId > 0)
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Bu numara ile bir is tanimli degil.";
                return _return;
            }

            return _return;

        }

    }
}