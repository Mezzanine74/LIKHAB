
using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // IsAsamalari
    public class IsAsamalari : IId, IRecordable, IIsAsamalari
    {
        public int Id { get; set; } // id (Primary key)
        public int IsId { get; set; } // IsId
        public System.DateTime? OnayaGidisZamani { get; set; } // OnayaGidisZamani
        public bool Onaylanmis { get; set; } // Onaylanmis
        public System.DateTime? OnayZamani { get; set; } // OnayZamani
        public bool Fatura { get; set; } // Fatura
        public System.DateTime? FaturaWhen { get; set; } // FaturaWhen
        public bool Olcum { get; set; } // Olcum
        public System.DateTime? OlcumWhen { get; set; } // OlcumWhen
        public bool Kontrol { get; set; } // Kontrol
        public System.DateTime? KontrolWhen { get; set; } // KontrolWhen
        public bool BeldEvrGeldi { get; set; } // BeldEvrGeldi
        public System.DateTime? BeldEvrGeldiWhen { get; set; } // BeldEvrGeldiWhen
        public bool BeldEvrGitti { get; set; } // BeldEvrGitti
        public System.DateTime? BeldEvrGittiWhen { get; set; } // BeldEvrGittiWhen
        public bool KadEvrGeldi { get; set; } // KadEvrGeldi
        public System.DateTime? KadEvrGeldiWhen { get; set; } // KadEvrGeldiWhen
        public bool KadEvrGitti { get; set; } // KadEvrGitti
        public System.DateTime? KadEvrGittiWhen { get; set; } // KadEvrGittiWhen
        public bool ProjeYapildi { get; set; } // ProjeYapildi
        public System.DateTime? ProjeYapildiWhen { get; set; } // ProjeYapildiWhen
        public bool OdemeAlindi { get; set; } // OdemeAlindi
        public System.DateTime? OdemeAlindiWhen { get; set; } // OdemeAlindiWhen
        public bool IsKapandi { get; set; } // IsKapandi
        public System.DateTime? IsKapandiWhen { get; set; } // IsKapandiWhen
        public bool MusteriyiBilgilendir { get; set; } // MusteriyiBilgilendir
        public System.DateTime? MusteriyiBilgilendirWhen { get; set; } // MusteriyiBilgilendirWhen
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }
        public string Uniqueidentifier { get; set; }

        // Foreign keys

        /// <summary>
        /// Parent Isler pointed by [IsAsamalari].([IsId]) (FK_IsAsamalari_Isler)
        /// </summary>
        public virtual Isler Isler { get; set; } // FK_IsAsamalari_Isler

        public IsAsamalari()
        {
            Onaylanmis = false;
            Fatura = false;
            Olcum = false;
            Kontrol = false;
            BeldEvrGeldi = false;
            BeldEvrGitti = false;
            KadEvrGeldi = false;
            KadEvrGitti = false;
            ProjeYapildi = false;
            OdemeAlindi = false;
            IsKapandi = false;
            MusteriyiBilgilendir = false;
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
