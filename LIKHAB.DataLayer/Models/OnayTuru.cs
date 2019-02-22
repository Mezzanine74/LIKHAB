using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // OnayTuru
    public class OnayTuru : IId
    {
        public int Id { get; set; } // id
        public int OnayKodu { get; set; } // OnayKodu (Primary key)
        public string Tanim { get; set; } // Tanim (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child OnayVerecekKisis (Many-to-Many) mapped by table [OnayTuruOnayVerecekKisi]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OnayVerecekKisi> OnayVerecekKisis { get; set; } // Many to many mapping

        public OnayTuru()
        {
            OnayVerecekKisis = new System.Collections.Generic.List<OnayVerecekKisi>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
