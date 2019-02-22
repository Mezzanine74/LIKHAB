
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Models.db
{

    [MetadataType(typeof(MusteriMetadata))]
    public partial class Musteri
    {
    }

    public class MusteriMetadata
    {
        [Required]
        public string AdiSoyadi { get; set; }
        [Required]
        public string TCkimlik_VergiNo { get; set; }
        [Required]
        public string VergiDairesi { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Faks { get; set; }
        public string Eposta { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Temsil Durumu Secilmeli")]
        public int TemsilDurumu { get; set; }
        [Required]
        public string Adress { get; set; }

    }
}