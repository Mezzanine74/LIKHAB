namespace LIKHAB.DataLayer.Interface
{
    public interface IIsler
    {
        int IsinCinsi { get; set; } // IsinCinsi
        int KoyuMahallesi { get; set; } // Koyu_Mahallesi
        int? IsinTuru { get; set; } // IsinTuru
        bool? KadastroyaAsliGibiVerilecek { get; set; } // KadastroyaAsliGibiVerilecek
        bool? Stopaj { get; set; } // Stopaj
        bool? Tevkifatli { get; set; } // Tevkifatli
        bool? KentselDonusum { get; set; } // KentselDonusum
        decimal? YolKilometre { get; set; } // YolKilometre
        bool? YolUcretiniElleGir { get; set; } // YolUcretiniElleGir
        int Musteri { get; set; } // Musteri
        string MusteriTemsilDurumu { get; set; } // MusteriTemsilDurumu (length: 100)

    }
}