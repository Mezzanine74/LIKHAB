using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System;

namespace LIKHAB.DataLayer.Models
{

    // Randevu
    public class Randevu : IId, IRecordable, IRandevu
    {
        public int Id { get; set; } // id (Primary key)
        public int Is { get; set; } // Is
        public string Title { get; set; } // Title (length: 200)
        public string Description { get; set; } // Description
        public System.DateTime? StartDate { get; set; } // StartDate
        public System.DateTime? EndDate { get; set; } // EndDate
        public string Location { get; set; } // Location (length: 200)
        public bool? AllDay { get; set; } // AllDay
        public int? Type { get; set; } // Type
        public string Subject { get; set; } // Subject (length: 200)
        public int? Status { get; set; } // Status
        public int? Label { get; set; } // Label
        public System.DateTime? WhenUpdated { get; set; } // WhenUpdated
        public string WhoCreated { get; set; } // WhoCreated (length: 50)
        public string WhoUpdated { get; set; } // WhoUpdated (length: 50)
        public System.DateTime? WhenCreated { get; set; } // WhenCreated
        public string Uniqueidentifier { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenDeleted { get; set; }

        // Foreign keys

        /// <summary>
        /// Parent Isler pointed by [Randevu].([Is]) (FK_Randevu_Isler)
        /// </summary>
        public virtual Isler Isler { get; set; } // FK_Randevu_Isler

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
