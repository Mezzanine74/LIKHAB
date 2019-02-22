namespace LIKHAB.DataLayer.Models
{

    // ViewIsinKucukDetayi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewIsinKucukDetayi
    {
        public System.Guid UniqueId { get; set; } // UniqueId (Primary key)
        public int Id { get; set; } // id (Primary key)
        public string IsinCinsi { get; set; } // IsinCinsi (Primary key) (length: 256)
        public string AdiSoyadi { get; set; } // AdiSoyadi (Primary key) (length: 50)
        public string MusteriTemsilDurumu { get; set; } // MusteriTemsilDurumu (length: 50)
        public decimal? AlinacakGenelToplam { get; set; } // AlinacakGenelToplam
    }

}

