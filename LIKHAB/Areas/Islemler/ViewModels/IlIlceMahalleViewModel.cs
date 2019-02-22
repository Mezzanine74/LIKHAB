using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Areas.Islemler.ViewModels
{
    public class IlViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Il secilmeli")]
        public string Il { get; set; }

        [RegularExpression(@"([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)", ErrorMessage = "Il katsayisi sayi olmali")]
        public decimal IlKatsayisi { get; set; }

    }

    public class IlceViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Il secilmeli")]
        public int ilId { get; set; }
        public string il { get; set; }
        [Required(ErrorMessage = "Ilce secilmeli")]
        public string ilce { get; set; }
    }

    public class KoyMahalleViewModel
    {
        public int id { get; set; }
        public string il { get; set; }

        [Required(ErrorMessage = "Ilce secilmeli")]
        public int ilceId { get; set; }
        public string ilce { get; set; }

        [Required(ErrorMessage = "Koy ve Mahalle secilmeli")]
        public string koyMahalle { get; set; }

        [Required(ErrorMessage = "Yol kilometre secilmeli")]
        [RegularExpression(@"([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)", ErrorMessage = "Yol kilometre sayi olmali")]
        public decimal YolKilometre { get; set; }
    }

}