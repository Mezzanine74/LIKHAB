
using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // IsBilgileri
    public class IsBilgileri : IId, IRecordable, IIsBilgileri
    {
        public int Id { get; set; } // id (Primary key)
        public int Is { get; set; } // Is
        public int Yili { get; set; } // Yili
        public int FenKayitNo { get; set; } // FenKayitNo
        public System.DateTime? FenKayitTarihi { get; set; } // FenKayitTarihi
        public string PaftaNo { get; set; } // PaftaNo (length: 100)
        public string AdaNo { get; set; } // AdaNo (length: 100)
        public string ParselNo { get; set; } // ParselNo (length: 100)
        public string Takipci { get; set; } // Takipci (length: 100)
        public string Maliki { get; set; } // Maliki (length: 200)
        public string Aciklama { get; set; } // Aciklama (length: 200)
        public string Cinsi { get; set; } // Cinsi (length: 100)
        public string Ilgilenen { get; set; } // Ilgilenen (length: 200)
        public string FaturaNo { get; set; } // FaturaNo (length: 200)
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        // Foreign keys

        /// <summary>
        /// Parent Isler pointed by [IsBilgileri].([Is]) (FK_IsBilgileri_Is)
        /// </summary>
        public virtual Isler Isler { get; set; } // FK_IsBilgileri_Is

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
