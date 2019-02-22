using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Models.db
{
    [MetadataType(typeof(AspNetUsersMetadata))]
    public partial class AspNetUsers
    {
    }

    public class AspNetUsersMetadata
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Email gerekli")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Lutfen gecerli bir email adresi girin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Kullanici Adi gerekli")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Adi Soyadi gerekli")]
        public string AdiSoyadi { get; set; }

    }
}