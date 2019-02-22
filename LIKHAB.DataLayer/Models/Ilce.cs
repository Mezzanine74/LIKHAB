
using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;

namespace LIKHAB.DataLayer.Models
{

    // Ilce
    public class Ilce : IId, IIlce
    {
        public int Id { get; set; } // id (Primary key)
        public int Il { get; set; } // Il
        public string Ilce_ { get; set; } // Ilce (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child KoyMahalles where [Koy_Mahalle].[Ilce] point to this entity (FK_Koy_Mahalle_Ilce)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<KoyMahalle> KoyMahalles { get; set; } // Koy_Mahalle.FK_Koy_Mahalle_Ilce

        // Foreign keys

        /// <summary>
        /// Parent Ili pointed by [Ilce].([Il]) (FK_Ilce_Ili)
        /// </summary>
        public virtual Ili Ili { get; set; } // FK_Ilce_Ili

        public Ilce()
        {
            KoyMahalles = new System.Collections.Generic.List<KoyMahalle>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
