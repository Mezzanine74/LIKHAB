using LIKHAB.Common;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class MusteriSecIsBilgilerindeViewModel : IId
    {
        public int Id { get; set; }
        [Required]
        public string AdiSoyadi { get; set; }
        [Required]
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

        public bool IsBilgilerindeZorunluTip { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}