using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // IsParametreleri
    public class IsParametreleri : IId, IRecordable, IIsParametreleri
    {
        public int Id { get; set; } // id (Primary key)
        public int Is { get; set; } // Is
        public decimal? YuzOlcumu { get; set; } // YuzOlcumu
        public int? AplikasyonKrokisiSayisi { get; set; } // AplikasyonKrokisiSayisi
        public int? ParselSayisi { get; set; } // ParselSayisi
        public int? NoktaSayisi { get; set; } // NoktaSayisi
        public decimal? ParselAlani { get; set; } // ParselAlani
        public decimal? BinaTabanAlani { get; set; } // BinaTabanAlani
        public decimal? InsaatAlani { get; set; } // InsaatAlani
        public int? BagimsizBolumSayisi { get; set; } // BagimsizBolumSayisi
        public int? BinaSayisi { get; set; } // BinaSayisi
        public int? PlanOrnegi { get; set; } // PlanOrnegi
        public int? KatSayisi { get; set; } // KatSayisi
        public int? BBolum { get; set; } // B_Bolum
        public decimal? OdaKatsayi { get; set; } // OdaKatsayi
        public bool? AraziyeGidilecekmi { get; set; } // AraziyeGidilecekmi
        public bool? AyniKisiyeAit { get; set; } // AyniKisiyeAit
        public bool? OdaBirimFiyatlariniKullan { get; set; } // OdaBirimFiyatlariniKullan
        public bool? Yuzde50CarpanUygula { get; set; } // Yuzde50CarpanUygula
        public decimal? YolUcreti { get; set; } // YolUcreti
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        // Foreign keys

        /// <summary>
        /// Parent Isler pointed by [IsParametreleri].([Is]) (FK_IsParametreleri_Isler)
        /// </summary>
        public virtual Isler Isler { get; set; } // FK_IsParametreleri_Isler

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
