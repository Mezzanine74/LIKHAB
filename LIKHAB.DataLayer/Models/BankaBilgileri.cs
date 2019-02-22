
using LIKHAB.Common;
using System;

namespace LIKHAB.DataLayer.Models
{

    // BankaBilgileri
    public class BankaBilgileri : IId, IRecordable
    {
        public int Id { get; set; } // id (Primary key)
        public string Banka { get; set; } // Banka (length: 50)
        public string Iban { get; set; } // Iban (length: 50)
        public string Uniqueidentifier { get; set; }
        public string WhoCreated { get; set; }
        public string WhoUpdated { get; set; }
        public string WhoDeleted { get; set; }
        public DateTime? WhenCreated { get; set; }
        public DateTime? WhenUpdated { get; set; }
        public DateTime? WhenDeleted { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
