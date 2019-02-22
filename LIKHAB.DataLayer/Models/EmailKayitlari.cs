
using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // EmailKayitlari
    public class EmailKayitlari : IId
    {
        public int Id { get; set; } // id (Primary key)
        public string Kime { get; set; } // Kime (length: 1000)
        public string Subject { get; set; } // Subject (length: 255)
        public string Body { get; set; } // Body
        public System.DateTime? NeZaman { get; set; } // NeZaman

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
