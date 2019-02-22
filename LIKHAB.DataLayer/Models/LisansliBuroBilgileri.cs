using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{

    // LisansliBuroBilgileri
    public class LisansliBuroBilgileri : IId
    {
        public int Id { get; set; } // id (Primary key)
        public string KimlikNo { get; set; } // KimlikNo (length: 50)
        public string AdiSoyadi { get; set; } // AdiSoyadi (length: 200)
        public string Unvani { get; set; } // Unvani (length: 200)
        public string LisansliBuroNo { get; set; } // LisansliBuroNo (length: 50)
        public string LisansliBelgeNo { get; set; } // LisansliBelgeNo (length: 50)
        public string OdaSicilNo { get; set; } // OdaSicilNo (length: 50)
        public string VergiNo { get; set; } // VergiNo (length: 50)
        public string Ili { get; set; } // Ili (length: 100)
        public string Adresi { get; set; } // Adresi (length: 256)
        public string Tel { get; set; } // Tel (length: 50)
        public string Faks { get; set; } // Faks (length: 50)
        public string Eposta { get; set; } // Eposta (length: 50)
        public string Websayfasi { get; set; } // Websayfasi (length: 50)
        public string VergiDairesi { get; set; } // VergiDairesi (length: 50)
        public string Ilcesi { get; set; } // Ilcesi (length: 100)

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }

}
