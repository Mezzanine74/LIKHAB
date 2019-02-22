using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // Isler
    public class Isler : IId, IRecordable, IIsler
    {
        public int Id { get; set; } // id (Primary key)
        public int IsinCinsi { get; set; } // IsinCinsi
        public int KoyuMahallesi { get; set; } // Koyu_Mahallesi
        public int? IsinTuru { get; set; } // IsinTuru
        public bool? KadastroyaAsliGibiVerilecek { get; set; } // KadastroyaAsliGibiVerilecek
        public bool? Stopaj { get; set; } // Stopaj
        public bool? Tevkifatli { get; set; } // Tevkifatli
        public bool? KentselDonusum { get; set; } // KentselDonusum
        public decimal? YolKilometre { get; set; } // YolKilometre
        public bool? YolUcretiniElleGir { get; set; } // YolUcretiniElleGir
        public int Musteri { get; set; } // Musteri
        public string MusteriTemsilDurumu { get; set; } // MusteriTemsilDurumu (length: 100)
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }

        // Reverse navigation

        /// <summary>
        /// Child IsAsamalaris where [IsAsamalari].[IsId] point to this entity (FK_IsAsamalari_Isler)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<IsAsamalari> IsAsamalaris { get; set; } // IsAsamalari.FK_IsAsamalari_Isler
        /// <summary>
        /// Child IsBilgileris where [IsBilgileri].[Is] point to this entity (FK_IsBilgileri_Is)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<IsBilgileri> IsBilgileris { get; set; } // IsBilgileri.FK_IsBilgileri_Is
        /// <summary>
        /// Child IsParametreleris where [IsParametreleri].[Is] point to this entity (FK_IsParametreleri_Isler)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<IsParametreleri> IsParametreleris { get; set; } // IsParametreleri.FK_IsParametreleri_Isler
        /// <summary>
        /// Child Randevus where [Randevu].[Is] point to this entity (FK_Randevu_Isler)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Randevu> Randevus { get; set; } // Randevu.FK_Randevu_Isler
        /// <summary>
        /// Child UcretDokumus where [UcretDokumu].[Is] point to this entity (FK_UcretDokumu_Isler)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UcretDokumu> UcretDokumus { get; set; } // UcretDokumu.FK_UcretDokumu_Isler

        // Foreign keys

        /// <summary>
        /// Parent IsinCinsi pointed by [Isler].([IsinCinsi]) (FK_Is_IsinCinsi)
        /// </summary>
        public virtual IsinCinsi IsinCinsi_IsinCinsi { get; set; } // FK_Is_IsinCinsi

        /// <summary>
        /// Parent IsTurleri pointed by [Isler].([IsinTuru]) (FK_Is_IsTurleri)
        /// </summary>
        public virtual IsTurleri IsTurleri { get; set; } // FK_Is_IsTurleri

        /// <summary>
        /// Parent KoyMahalle pointed by [Isler].([KoyuMahallesi]) (FK_Is_Koy_Mahalle)
        /// </summary>
        public virtual KoyMahalle KoyMahalle { get; set; } // FK_Is_Koy_Mahalle

        /// <summary>
        /// Parent Musteri pointed by [Isler].([Musteri]) (FK_Is_Musteri)
        /// </summary>
        public virtual Musteri Musteri_Musteri { get; set; } // FK_Is_Musteri

        public Isler()
        {
            IsAsamalaris = new System.Collections.Generic.List<IsAsamalari>();
            IsBilgileris = new System.Collections.Generic.List<IsBilgileri>();
            IsParametreleris = new System.Collections.Generic.List<IsParametreleri>();
            Randevus = new System.Collections.Generic.List<Randevu>();
            UcretDokumus = new System.Collections.Generic.List<UcretDokumu>();
        }
    }

}
