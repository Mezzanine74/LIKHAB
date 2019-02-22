using LIKHAB.BusinessLogic.Helpers;

namespace LIKHAB.Codes.Helpers
{
    public class Etiketler
    {
        // Randevu Etiketleri
        public void EtiketleriEkle(DevExpress.Web.Mvc.MVCxAppointmentStorage appointmentStorage)
        {
            appointmentStorage.Labels.Clear();

            foreach (EtiketElemani etiketElemani in BusinessLogic.Helpers.Etiketler.RandevuEtiketListesi)
            {
                appointmentStorage.Labels.Add(appointmentStorage.Labels.CreateNewLabel(
                    etiketElemani.Id,
                    etiketElemani.DisplayName,
                    etiketElemani.MenuCaption,
                    etiketElemani.Color)
                );
            }
        }
    }
}