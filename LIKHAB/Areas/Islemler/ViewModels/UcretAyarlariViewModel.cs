using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Areas.Islemler.ViewModels
{
    public class UcretAyarlariViewModel
    {

        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "Is Detayi girilmeli")]
        public string IsDetayi { get; set; }

        [Required(ErrorMessage = "Ucret Kodu girilmeli")]
        public string UcretKodu { get; set; }

        [Required(ErrorMessage = "Aciklama girilmeli")]
        public string Aciklama { get; set; }

        public bool Kullan { get; set; }

        [Required(ErrorMessage = "Parametre girilmeli")]
        [RegularExpression(@"([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)", ErrorMessage = "Paramatre sayi olmali")]
        public decimal Parametre { get; set; }

    }
}