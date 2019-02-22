using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // OnayVerecekKisi
    public class OnayVerecekKisi : IId
    {
        public int Id { get; set; } // id
        public string UserId { get; set; } // UserId (Primary key) (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child OnayTurus (Many-to-Many) mapped by table [OnayTuruOnayVerecekKisi]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OnayTuru> OnayTurus { get; set; } // Many to many mapping

        public OnayVerecekKisi()
        {
            OnayTurus = new System.Collections.Generic.List<OnayTuru>();
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
