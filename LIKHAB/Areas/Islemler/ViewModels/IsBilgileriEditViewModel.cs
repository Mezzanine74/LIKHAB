using System;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Areas.Islemler.ViewModels
{
    public class IsBilgileriEditViewModel
    {
        public int id { get; set; }
        [Required]
        public int Is { get; set; }

        [Required]
        public int FenKayitNo { get; set; }
        [Required]
        public Nullable<System.DateTime> FenKayitTarihi { get; set; }
        [Required]
        public string AdaNo { get; set; }
        [Required]
        public string ParselNo { get; set; }
        [Range(0.01, 999999999, ErrorMessage = "Yuzolcumu girilmeli")]
        public decimal Yuzolcumu { get; set; }
        [Required]
        public string PaftaNo { get; set; }

        [Required]
        public string Maliki { get; set; }
        [Required]
        public string IsSahibi { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }

        public string Cinsi { get; set; }
        [Required]
        public int IsinTuru { get; set; }

        public string Ilgilenen { get; set; }
        public string Notlar { get; set; }
        public string FaturaNo { get; set; }
        public decimal UcretToplam { get; set; }
        public string Ili { get; set; }
        public string Ilcesi { get; set; }
        public string KoyMahalle { get; set; }
        public int IlcesiId { get; set; }
        public int KoyMahalleId { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }

        public decimal Katsayi { get; set; }
        public decimal Yol { get; set; }
        public decimal FaturaAlinanNetUcret { get; set; }
        public decimal TahsilatUcreti { get; set; }
        public Nullable<bool> Stopaj { get; set; }

    }
}