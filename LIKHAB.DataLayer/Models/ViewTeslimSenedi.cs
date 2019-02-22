namespace LIKHAB.DataLayer.Models
{

    // ViewTeslimSenedi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewTeslimSenedi
    {
        public int IsId { get; set; } // isId (Primary key)
        public string Cinsi { get; set; } // Cinsi (Primary key) (length: 18)
        public string KoyMahalle { get; set; } // Koy_Mahalle (Primary key) (length: 100)
        public string PaftaNo { get; set; } // PaftaNo (length: 100)
        public string AdaNo { get; set; } // AdaNo (length: 100)
        public string ParselNo { get; set; } // ParselNo (length: 100)
        public string YuzOlcumu { get; set; } // YuzOlcumu (length: 4000)
        public string Tanim { get; set; } // Tanim (Primary key) (length: 256)
        public string FenKayitTarihi { get; set; } // FenKayitTarihi (length: 4000)
        public string FenKayitTarihiGun { get; set; } // FenKayitTarihiGUN (Primary key) (length: 4000)
        public string FenKayitTarihiAy { get; set; } // FenKayitTarihiAY (Primary key) (length: 4000)
        public string FenKayitTarihiYil { get; set; } // FenKayitTarihiYIL (Primary key) (length: 4000)
        public string LisansliBuroSahibi { get; set; } // LisansliBuroSahibi (length: 200)
        public string LisansliBuroSahibiUnvani { get; set; } // LisansliBuroSahibiUnvani (length: 200)
        public string IsSahibi { get; set; } // isSahibi (Primary key) (length: 200)
        public string BirimFiyati { get; set; } // BirimFiyati (length: 4000)
        public string ToplamFiyat { get; set; } // ToplamFiyat (length: 4000)
    }

}
