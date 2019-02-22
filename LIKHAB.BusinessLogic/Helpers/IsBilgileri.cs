using LIKHAB.DataLayer.DBContext;
using System.Linq;

namespace LIKHAB.BusinessLogic.Helpers
{
    public class IsBilgileri
    {
        //* query string id gelecek(Isler i refere eden)
        //* bu is icin henuz is bilgisi girilmemis olacak
        //* boyle bir is mevcut olacak
        //* bu is icin randevu onaylanmis olacak
        //* onay biletinin bitmemis olmasi gerekecek

        public class GirisHatalari
        {
            public bool HataVarmi { get; set; }
            public string HataMesaji { get; set; }

        }

        public static GirisHatalari IsBilgileriGirisHatalari(int isId)
        {
            GirisHatalari _return = new GirisHatalari() { HataVarmi = false, HataMesaji = "hata yok" };

            if (!IsMevcutmu(isId))
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Boyle bir is mevcut degil!";
                return _return;
            };

            if (IsBilgileriMevcutmu(isId))
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Is bilgileri daha once girilmis, tekrar tanimlanamaz!";
                return _return;
            }

            if (!RandevuOnaylanmismi(isId))
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Bu isle ilgili randevu henuz onaylanmamis!";
                return _return;
            }

            if (RandevuBiletiBittimi(isId))
            {
                _return.HataVarmi = true;
                _return.HataMesaji = "Bu isle ilgili randevu onaylandiktan sonra olusan biletin suresi dolmus!";
                return _return;
            }

            return _return;
        }

        public static bool IsBilgileriMevcutmu(int isId)
        {

            using (var db = new LikhabDBContext())
            {
                if (db.IsBilgileris.Where(c => c.Is == isId).ToList().Count() > 0)
                    return true;
                db.Dispose();
            }

            return false;
        }

        public static bool IsMevcutmu(int isId)
        {

            using (var db = new LikhabDBContext())
            {
                if (db.Islers.Where(c => c.Id == isId).ToList().Count() > 0)
                    return true;
            }

            return false;
        }

        public static bool RandevuOnaylanmismi(int isId)
        {
            using (var db = new LikhabDBContext())
            {
                var a = db.IsAsamalaris.FirstOrDefault(c => c.IsId == isId);

                if (a != null)
                {
                    return a.Onaylanmis;
                }

                return false;

            }

        }

        public static bool RandevuBiletiBittimi(int isId)
        {

            if (Randevu.RandevuBiletiKalanToplamSaniye(isId) > 0)
                return false;

            return true;
        }
    }
}