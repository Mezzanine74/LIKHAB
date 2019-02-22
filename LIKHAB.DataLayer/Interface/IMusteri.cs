namespace LIKHAB.DataLayer.Interface
{
    public interface IMusteri
    {
        string AdiSoyadi { get; set; } // AdiSoyadi (length: 200)
        string TCkimlikVergiNo { get; set; } // TCkimlik_VergiNo (length: 50)
        string VergiDairesi { get; set; } // VergiDairesi (length: 50)
        string Telefon1 { get; set; } // Telefon1 (length: 50)
        string Telefon2 { get; set; } // Telefon2 (length: 50)
        string Faks { get; set; } // Faks (length: 50)
        string Eposta { get; set; } // Eposta (length: 50)
        int TemsilDurumu { get; set; } // TemsilDurumu
        string Adress { get; set; } // Adress (length: 256)
    }
}