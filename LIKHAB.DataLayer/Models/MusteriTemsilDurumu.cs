using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // MusteriTemsilDurumu
    public class MusteriTemsilDurumu : IId
    {
        public int Id { get; set; } // id (Primary key)
        public string Tanim { get; set; } // Tanim (length: 100)
        public bool StopajdaGoster { get; set; } // StopajdaGoster
        public bool IsBilgilerindeZorunluTip { get; set; } // IsBilgilerindeZorunluTip

        // Reverse navigation

        /// <summary>
        /// Child Musteris where [Musteri].[TemsilDurumu] point to this entity (FK_Musteri_MusteriTemsilDurumu)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Musteri> Musteris { get; set; } // Musteri.FK_Musteri_MusteriTemsilDurumu

        public MusteriTemsilDurumu()
        {
            Musteris = new System.Collections.Generic.List<Musteri>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
