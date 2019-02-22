using LIKHAB.Common;
using System;

namespace LIKHAB.DataLayer.Models
{

    // UcretDokumu
    public class UcretDokumu : IId, IRecordable
    {
        public int Id { get; set; } // id (Primary key)
        public int? Is { get; set; } // Is
        public decimal? YolUcreti { get; set; } // YolUcreti
        public decimal? DenetimUcreti { get; set; } // DenetimUcreti
        public decimal? DamgaVergisi { get; set; } // DamgaVergisi
        public decimal? BelgeUcreti { get; set; } // BelgeUcreti
        public decimal? KontrolUcreti { get; set; } // KontrolUcreti
        public decimal? Toplam { get; set; } // Toplam
        public decimal? ToplamBrutUcret { get; set; } // ToplamBrutUcret
        public decimal? Stopaj20Percent { get; set; } // Stopaj20percent
        public decimal? KesintilerToplami { get; set; } // KesintilerToplami
        public decimal? GenelToplam { get; set; } // GenelToplam
        public decimal? Kdv18Percent { get; set; } // KDV18percent
        public decimal? TevkifEdilenKdv { get; set; } // TevkifEdilenKDV
        public decimal? TahsilEdilenKdv { get; set; } // TahsilEdilenKDV
        public decimal? NetAlinan { get; set; } // NetAlinan
        public decimal? AlinacakGenelToplam { get; set; } // AlinacakGenelToplam
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        // Foreign keys

        /// <summary>
        /// Parent Isler pointed by [UcretDokumu].([Is]) (FK_UcretDokumu_Isler)
        /// </summary>
        public virtual Isler Isler { get; set; } // FK_UcretDokumu_Isler

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
