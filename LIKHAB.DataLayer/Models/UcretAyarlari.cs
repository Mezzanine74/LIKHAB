using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;

namespace LIKHAB.DataLayer.Models
{

    // UcretAyarlari
    public class UcretAyarlari : IId, IUcretAyarlari
    {
        public int Id { get; set; } // id (Primary key)
        public string IsDetayi { get; set; } // IsDetayi (length: 256)
        public string UcretKodu { get; set; } // UcretKodu (length: 50)
        public string Aciklama { get; set; } // Aciklama (length: 256)
        public bool Kullan { get; set; } // Kullan
        public decimal Parametre { get; set; } // Parametre

        public UcretAyarlari()
        {
            Kullan = false;
        }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
