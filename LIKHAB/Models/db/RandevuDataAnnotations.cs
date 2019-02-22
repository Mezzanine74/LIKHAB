using System;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.Models.db
{
    [MetadataType(typeof(RandevuMetadata))]
    public partial class Randevu
    {
    }

    public class RandevuMetadata
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public Nullable<System.DateTime> StartDate { get; set; }

        [Required]
        public Nullable<System.DateTime> EndDate { get; set; }

        [Required]
        public string Description { get; set; }

    }

}
