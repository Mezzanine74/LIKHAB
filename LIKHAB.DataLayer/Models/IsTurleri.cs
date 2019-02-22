using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // IsTurleri
    public class IsTurleri : IId
    {
        public int Id { get; set; } // id (Primary key)
        public string Tanim { get; set; } // Tanim (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Islers where [Isler].[IsinTuru] point to this entity (FK_Is_IsTurleri)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Isler> Islers { get; set; } // Isler.FK_Is_IsTurleri

        public IsTurleri()
        {
            Islers = new System.Collections.Generic.List<Isler>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
