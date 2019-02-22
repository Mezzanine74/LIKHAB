using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Areas.Islemler.ViewModels
{

    public class MusteriViewModel
    {
        public int id { get; set; }

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

    }

    public class MusteriSecViewModel
    {
        public int id { get; set; }

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

    }

    public class MusteriSecIsBilgilerindeViewModel
    {
        public int id { get; set; }
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

    }



}