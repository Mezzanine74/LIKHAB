using LIKHAB.Common;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class MusteriSecViewModel : IId
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adi Soyadi girilmeli")]
        public string AdiSoyadi { get; set; }

        [Required(ErrorMessage = "Kimlik ya da VergiNo girilmeli")]
        public string TCkimlik_VergiNo { get; set; }
        [Required(ErrorMessage = "Vergi Dairesi girilmeli")]
        public string VergiDairesi { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Faks { get; set; }
        public string Eposta { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Temsil Durumu Secilmeli")]
        public int TemsilDurumu { get; set; }
        [Required(ErrorMessage = "Adres girilmeli")]
        public string Adress { get; set; }
        public bool StopajdaGoster { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}