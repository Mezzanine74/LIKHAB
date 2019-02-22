using System;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Areas.Islemler.ViewModels
{
    public class IsBilgileriViewModel
    {
        public int id { get; set; }
        [Required]
        public int Is { get; set; }

        public int Yili { get; set; }
        [Required]
        public int FenKayitNo { get; set; }
        [Required]
        public Nullable<System.DateTime> FenKayitTarihi { get; set; }
        [Required]
        public string PaftaNo { get; set; }
        [Required]
        public string AdaNo { get; set; }
        [Required]
        public string ParselNo { get; set; }
        public string Takipci { get; set; }
        [Required]
        public string Maliki { get; set; }
        [Required]
        public string Aciklama { get; set; }
        [Required]
        public string Cinsi { get; set; }
        public bool IsKapandi { get; set; }
        [Required]
        [Range(0.01, 999999999, ErrorMessage = "Yuzolcumu girilmeli")]
        public decimal Yuzolcumu { get; set; }
        public string Ilgilenen { get; set; }
        public string FaturaNo { get; set; }

        // detaylar
        public string IsinCinsi { get; set; }
        public string Ili { get; set; }
        public string Ilcesi { get; set; }
        public string KoyMahalle { get; set; }
        public string IsSahibi { get; set; }
        public string IlKatsayi { get; set; }

    }

}