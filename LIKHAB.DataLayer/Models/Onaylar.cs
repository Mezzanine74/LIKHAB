using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // Onaylar
    public class Onaylar : IId
    {
        public int Id { get; set; } // id (Primary key)
        public int OnayKodu { get; set; } // OnayKodu
        public string UserId { get; set; } // UserId (length: 128)
        public int OnaylananSatirId { get; set; } // OnaylananSatirId
        public System.DateTime? OnayZamani { get; set; } // OnayZamani

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
