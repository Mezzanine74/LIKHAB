namespace LIKHAB.DataLayer.Interface
{
    public interface IIsBilgileri
    {
        int Is { get; set; } // Is
        int Yili { get; set; } // Yili
        int FenKayitNo { get; set; } // FenKayitNo
        System.DateTime? FenKayitTarihi { get; set; } // FenKayitTarihi
        string PaftaNo { get; set; } // PaftaNo (length: 100)
        string AdaNo { get; set; } // AdaNo (length: 100)
        string ParselNo { get; set; } // ParselNo (length: 100)
        string Takipci { get; set; } // Takipci (length: 100)
        string Maliki { get; set; } // Maliki (length: 200)
        string Aciklama { get; set; } // Aciklama (length: 200)
        string Cinsi { get; set; } // Cinsi (length: 100)
        string Ilgilenen { get; set; } // Ilgilenen (length: 200)
        string FaturaNo { get; set; } // FaturaNo (length: 200)
    }
}