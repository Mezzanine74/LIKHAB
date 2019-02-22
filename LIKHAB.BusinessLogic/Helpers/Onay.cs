using LIKHAB.Common;
using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using LIKHAB.Services.Email;
using System.Linq;

namespace LIKHAB.BusinessLogic.Helpers
{
    public class Onay
    {
        private static LikhabDBContext db = new LikhabDBContext();

        public static bool ValidateOnayEntry(int onayKodu, string userId, int onaylananSatirId)
        {

            if (!db.OnayTurus.Any(c => c.OnayVerecekKisis.Any(d => d.UserId == userId) && c.OnayKodu == onayKodu))
            {
                return false;
            }

            if (!db.Randevus.Any(c => c.Id == onaylananSatirId))
            {
                return false;
            }

            return true;
        }

        public static bool ProcessOnayEntry(int onayKodu, string userId, int onaylananSatirId)
        {

            if (ValidateOnayEntry(onayKodu, userId, onaylananSatirId))
            {
                int isId = 0;

                if (onayKodu == (int)Common.OnayTuru.Randevu)
                {

                    isId = db.Randevus.FirstOrDefault(c => c.Id == onaylananSatirId).Is;
                }

                var onay = db.Onaylars.Where(c => c.OnayKodu == onayKodu && c.UserId == userId && c.OnaylananSatirId == onaylananSatirId).ToList();
                // check if already approved
                if (onay.Count() > 0)
                {
                    // already approved so Delete
                    Onaylar toDelete = onay[0];
                    db.Onaylars.Attach(toDelete);
                    db.Onaylars.Remove(toDelete);
                }
                else
                {
                    // not approved yet, approve
                    var toAdd = new Onaylar()
                    {
                        OnayKodu = onayKodu,
                        OnaylananSatirId = onaylananSatirId,
                        OnayZamani = LocalTime.GetIstanbul(),
                        UserId = userId
                    };
                    db.Onaylars.Attach(toAdd);
                    db.Onaylars.Add(toAdd);

                }

                db.SaveChanges();

                // Genel olarak onayla

                var randevu = db.Randevus.FirstOrDefault(c => c.Id == onaylananSatirId);
                int _isId = 0;

                if (randevu != null)
                {
                    _isId = randevu.Is;
                }

                var isler = db.IsAsamalaris.FirstOrDefault(c => c.IsId == _isId);

                var onaylanmis = db.ViewRandevuGenelOnayDurumu.Where(c => c.RandevuId == onaylananSatirId).ToList()[0].Onaylanmis;

                if (isler != null)
                {
                    if (onaylanmis == 1)
                    {
                        isler.Onaylanmis = true;
                        isler.OnayZamani = Common.LocalTime.GetIstanbul();

                        // randevu statusu 'Is Yapilmadi'ya donecek

                        int etiketId = Etiketler.RandevuEtiketListesi.FirstOrDefault(c => c.DisplayName == Etiketler.IsYapilmadi).Id;
                        Helpers.Randevu.EtiketDegistirbyIsId(etiketId, isId);
                    }
                    else
                    {
                        isler.Onaylanmis = false;
                        isler.OnayZamani = null;

                        // randevu statusu 'Onay Bekleniyor'ya donecek
                        int etiketId = Etiketler.RandevuEtiketListesi.FirstOrDefault(c => c.DisplayName == Etiketler.OnayBekliyor).Id;
                        Helpers.Randevu.EtiketDegistirbyIsId(etiketId, isId);
                    }
                }

                db.SaveChanges();

                // onaylanmis ise email notification gonder
                if (onaylanmis == 1)
                {
                    // geri bildirim emaili gonder
                    SendEmail.SendAway("onay body", EmailNotificationType.RandevuOnayiniGeriBildir, onaylananSatirId, isId);
                    return true;
                }

            }

            return false;

        }
    }
}