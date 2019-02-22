namespace LIKHAB.DataLayer.Interface
{
    public interface IUcretAyarlari
    {
        string IsDetayi { get; set; } // IsDetayi (length: 256)
        string UcretKodu { get; set; } // UcretKodu (length: 50)
        string Aciklama { get; set; } // Aciklama (length: 256)
        bool Kullan { get; set; } // Kullan
        decimal Parametre { get; set; } // Parametre
    }
}