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

    public partial class Koy_Mahalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Koy_Mahalle()
        {
            this.Isler = new HashSet<Isler>();
        }
    
        public int id { get; set; }
        public int Ilce { get; set; }
        public string Koy_Mahalle1 { get; set; }
        public decimal YolKilometre { get; set; }
    
        public virtual Ilce Ilce1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Isler> Isler { get; set; }
    }
}
