using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // Musteri
    public class Musteri : IId, IRecordable, IMusteri
    {
        public int Id { get; set; } // id (Primary key)
        public string AdiSoyadi { get; set; } // AdiSoyadi (length: 200)
        public string TCkimlikVergiNo { get; set; } // TCkimlik_VergiNo (length: 50)
        public string VergiDairesi { get; set; } // VergiDairesi (length: 50)
        public string Telefon1 { get; set; } // Telefon1 (length: 50)
        public string Telefon2 { get; set; } // Telefon2 (length: 50)
        public string Faks { get; set; } // Faks (length: 50)
        public string Eposta { get; set; } // Eposta (length: 50)
        public int TemsilDurumu { get; set; } // TemsilDurumu
        public string Adress { get; set; } // Adress (length: 256)
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        // Reverse navigation

        /// <summary>
        /// Child Islers where [Isler].[Musteri] point to this entity (FK_Is_Musteri)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Isler> Islers { get; set; } // Isler.FK_Is_Musteri

        // Foreign keys

        /// <summary>
        /// Parent MusteriTemsilDurumu pointed by [Musteri].([TemsilDurumu]) (FK_Musteri_MusteriTemsilDurumu)
        /// </summary>
        public virtual MusteriTemsilDurumu MusteriTemsilDurumu { get; set; } // FK_Musteri_MusteriTemsilDurumu

        public Musteri()
        {
            Islers = new System.Collections.Generic.List<Isler>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
