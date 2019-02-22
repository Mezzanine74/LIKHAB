namespace LIKHAB.DataLayer.Models
{

    // ViewRandevuOnayDurumu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevuOnayDurumu
    {
        public long? UniqueId { get; set; } // UniqueId
        public int RandevuId { get; set; } // RandevuId (Primary key)
        public int? OnayId { get; set; } // OnayId
        public int OnayKodu { get; set; } // OnayKodu (Primary key)
        public string OnayVerecekUserId { get; set; } // OnayVerecekUserId (Primary key) (length: 128)
        public string UserName { get; set; } // UserName (Primary key) (length: 50)
        public string AdiSoyadi { get; set; } // AdiSoyadi (Primary key) (length: 50)
        public System.DateTime? OnayZamani { get; set; } // OnayZamani
    }

}
