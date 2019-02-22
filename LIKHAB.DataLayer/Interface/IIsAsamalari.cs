namespace LIKHAB.DataLayer.Interface
{
    public interface IIsAsamalari
    {
        int IsId { get; set; } // IsId
        System.DateTime? OnayaGidisZamani { get; set; } // OnayaGidisZamani
        bool Onaylanmis { get; set; } // Onaylanmis
        System.DateTime? OnayZamani { get; set; } // OnayZamani
        bool Fatura { get; set; } // Fatura
        System.DateTime? FaturaWhen { get; set; } // FaturaWhen
        bool Olcum { get; set; } // Olcum
        System.DateTime? OlcumWhen { get; set; } // OlcumWhen
        bool Kontrol { get; set; } // Kontrol
        System.DateTime? KontrolWhen { get; set; } // KontrolWhen
        bool BeldEvrGeldi { get; set; } // BeldEvrGeldi
        System.DateTime? BeldEvrGeldiWhen { get; set; } // BeldEvrGeldiWhen
        bool BeldEvrGitti { get; set; } // BeldEvrGitti
        System.DateTime? BeldEvrGittiWhen { get; set; } // BeldEvrGittiWhen
        bool KadEvrGeldi { get; set; } // KadEvrGeldi
        System.DateTime? KadEvrGeldiWhen { get; set; } // KadEvrGeldiWhen
        bool KadEvrGitti { get; set; } // KadEvrGitti
        System.DateTime? KadEvrGittiWhen { get; set; } // KadEvrGittiWhen
        bool ProjeYapildi { get; set; } // ProjeYapildi
        System.DateTime? ProjeYapildiWhen { get; set; } // ProjeYapildiWhen
        bool OdemeAlindi { get; set; } // OdemeAlindi
        System.DateTime? OdemeAlindiWhen { get; set; } // OdemeAlindiWhen
        bool IsKapandi { get; set; } // IsKapandi
        System.DateTime? IsKapandiWhen { get; set; } // IsKapandiWhen
        bool MusteriyiBilgilendir { get; set; } // MusteriyiBilgilendir
        System.DateTime? MusteriyiBilgilendirWhen { get; set; } // MusteriyiBilgilendirWhen
    }
}