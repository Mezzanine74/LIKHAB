
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Models.db
{

    [MetadataType(typeof(IlMetadata))]
    public partial class Il
    {
    }

    public class IlMetadata
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Il Secilmeli")]
        public string Il { get; set; }

        public decimal IlKatsayisi { get; set; }

    }
}