
using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // IsinCinsi
    public class IsinCinsi : IId
    {
        public int Id { get; set; } // id (Primary key)
        public string Tanim { get; set; } // Tanim (length: 256)
        public bool FenKayitNoSifirMi { get; set; } // FenKayitNoSifirMi

        // Reverse navigation

        /// <summary>
        /// Child Islers where [Isler].[IsinCinsi] point to this entity (FK_Is_IsinCinsi)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Isler> Islers { get; set; } // Isler.FK_Is_IsinCinsi

        public IsinCinsi()
        {
            FenKayitNoSifirMi = false;
            Islers = new System.Collections.Generic.List<Isler>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
