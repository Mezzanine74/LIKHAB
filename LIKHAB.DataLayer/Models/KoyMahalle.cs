using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;

namespace LIKHAB.DataLayer.Models
{

    // Koy_Mahalle
    public class KoyMahalle : IId, IKoyMahalle
    {
        public int Id { get; set; } // id (Primary key)
        public int Ilce { get; set; } // Ilce
        public string KoyMahalle_ { get; set; } // Koy_Mahalle (length: 100)
        public decimal YolKilometre { get; set; } // YolKilometre

        // Reverse navigation

        /// <summary>
        /// Child Islers where [Isler].[Koyu_Mahallesi] point to this entity (FK_Is_Koy_Mahalle)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Isler> Islers { get; set; } // Isler.FK_Is_Koy_Mahalle

        // Foreign keys

        /// <summary>
        /// Parent Ilce pointed by [Koy_Mahalle].([Ilce]) (FK_Koy_Mahalle_Ilce)
        /// </summary>
        public virtual Ilce Ilce_Ilce { get; set; } // FK_Koy_Mahalle_Ilce

        public KoyMahalle()
        {
            Islers = new System.Collections.Generic.List<Isler>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
