using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // Yillar
    public class Yillar : IId
    {
        public int Id { get; set; } // id (Primary key)
        public int Yil { get; set; } // Yil

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
