//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIKHAB.Models.db
{
    using System.Collections.Generic;

    public partial class OnayVerecekKisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OnayVerecekKisi()
        {
            this.OnayTuruOnayVerecekKisi = new HashSet<OnayTuruOnayVerecekKisi>();
        }
    
        public int id { get; set; }
        public string UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnayTuruOnayVerecekKisi> OnayTuruOnayVerecekKisi { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
