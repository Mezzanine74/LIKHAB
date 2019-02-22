
using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;

namespace LIKHAB.DataLayer.Models
{

    // Ili
    public class Ili : IId, IIli
    {
        public int Id { get; set; } // id (Primary key)
        public string Il { get; set; } // Il (length: 100)
        public decimal IlKatsayisi { get; set; } // IlKatsayisi

        // Reverse navigation

        /// <summary>
        /// Child Ilces where [Ilce].[Il] point to this entity (FK_Ilce_Ili)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Ilce> Ilces { get; set; } // Ilce.FK_Ilce_Ili

        public Ili()
        {
            Ilces = new System.Collections.Generic.List<Ilce>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
