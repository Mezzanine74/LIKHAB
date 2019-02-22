namespace LIKHAB.DataLayer.Interface
{
    public interface IIsParametreleri
    {
        int Is { get; set; } // Is
        decimal? YuzOlcumu { get; set; } // YuzOlcumu
        int? AplikasyonKrokisiSayisi { get; set; } // AplikasyonKrokisiSayisi
        int? ParselSayisi { get; set; } // ParselSayisi
        int? NoktaSayisi { get; set; } // NoktaSayisi
        decimal? ParselAlani { get; set; } // ParselAlani
        decimal? BinaTabanAlani { get; set; } // BinaTabanAlani
        decimal? InsaatAlani { get; set; } // InsaatAlani
        int? BagimsizBolumSayisi { get; set; } // BagimsizBolumSayisi
        int? BinaSayisi { get; set; } // BinaSayisi
        int? PlanOrnegi { get; set; } // PlanOrnegi
        int? KatSayisi { get; set; } // KatSayisi
        int? BBolum { get; set; } // B_Bolum
        decimal? OdaKatsayi { get; set; } // OdaKatsayi
        bool? AraziyeGidilecekmi { get; set; } // AraziyeGidilecekmi
        bool? AyniKisiyeAit { get; set; } // AyniKisiyeAit
        bool? OdaBirimFiyatlariniKullan { get; set; } // OdaBirimFiyatlariniKullan
        bool? Yuzde50CarpanUygula { get; set; } // Yuzde50CarpanUygula
        decimal? YolUcreti { get; set; } // YolUcreti
    }
}