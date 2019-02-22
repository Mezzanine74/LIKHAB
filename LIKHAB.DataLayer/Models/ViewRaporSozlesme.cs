namespace LIKHAB.DataLayer.Models
{

    // View_RaporSozlesme
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRaporSozlesme
    {
        public int IsId { get; set; } // IsId (Primary key)
        public string IlinAdi { get; set; } // IlinAdi (Primary key) (length: 100)
        public string Ilce { get; set; } // Ilce (Primary key) (length: 100)
        public string KoyMahalle { get; set; } // Koy_Mahalle (Primary key) (length: 100)
        public string IsSahibi { get; set; } // IsSahibi (Primary key) (length: 200)
        public string IsSahibiVeUnvani { get; set; } // IsSahibiVeUnvani (length: 301)
        public string MusteriTemsilDurumuIsler { get; set; } // MusteriTemsilDurumuIsler (length: 100)
        public string IsinCinsiTanim { get; set; } // IsinCinsiTanim (Primary key) (length: 256)
        public string RandevuZamani { get; set; } // RandevuZamani (Primary key)
        public string Toplam { get; set; } // Toplam (length: 4000)
        public string Kdv { get; set; } // KDV (length: 4000)
        public string GenelToplam { get; set; } // GenelToplam (length: 4000)
        public string MalikiIbAdiSoyadi { get; set; } // MalikiIBAdiSoyadi (Primary key) (length: 200)
        public string IsSahibiTCkimlikVergiNo { get; set; } // IsSahibiTCkimlik_VergiNo (Primary key) (length: 50)
        public string IsSahibiTelefon1 { get; set; } // IsSahibiTelefon1 (length: 50)
        public string IsSahibiAdress { get; set; } // IsSahibiAdress (length: 256)
        public string LisansSahibiAdiSoyadi { get; set; } // LisansSahibi_AdiSoyadi (length: 200)
        public string LisansliBuroNo { get; set; } // LisansliBuroNo (length: 50)
        public string LisansliBelgeNo { get; set; } // LisansliBelgeNo (length: 50)
        public string OdaSicilNo { get; set; } // OdaSicilNo (length: 50)
        public string LisansSahibiIli { get; set; } // LisansSahibiIli (length: 100)
        public string AdaParselNo { get; set; } // AdaParselNo (Primary key) (length: 201)
        public string PaftaNo { get; set; } // PaftaNo (length: 100)
        public string FenKayitTarihiNo { get; set; } // FenKayitTarihiNo (Primary key)
        public string FenKayitTarihi { get; set; } // FenKayitTarihi (Primary key)
        public string FenKayitTarihiGun { get; set; } // FenKayitTarihiGUN (Primary key) (length: 4000)
        public string FenKayitTarihiAy { get; set; } // FenKayitTarihiAY (Primary key) (length: 4000)
        public string FenKayitTarihiYil { get; set; } // FenKayitTarihiYIL (Primary key) (length: 4000)
        public string Yuzolcumu { get; set; } // Yuzolcumu (length: 4000)
        public int IsinCinsiId { get; set; } // IsinCinsiId (Primary key)
    }

}
