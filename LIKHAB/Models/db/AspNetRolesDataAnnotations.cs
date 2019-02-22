using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Models.db
{
    [MetadataType(typeof(AspNetRolesMetadata))]
    public partial class AspNetRoles
    {
    }

    public class AspNetRolesMetadata
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Rol Adi gerekli")]
        public string Name { get; set; }

    }
}