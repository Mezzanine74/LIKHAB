namespace LIKHAB.DataLayer.Models
{

    // ViewRandevuTalebiReportDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevuTalebiReportDetail
    {
        public System.Guid UniqueId { get; set; } // UniqueId (Primary key)
        public string Tanim { get; set; } // Tanim (Primary key) (length: 256)
        public string AdiSoyadi { get; set; } // AdiSoyadi (Primary key) (length: 50)
        public string Il { get; set; } // Il (Primary key) (length: 50)
        public string Ilce { get; set; } // Ilce (Primary key) (length: 50)
        public string KoyMahalle { get; set; } // Koy_Mahalle (Primary key) (length: 50)
        public string Location { get; set; } // Location (length: 500)
        public System.DateTime? StartDate { get; set; } // StartDate
        public System.DateTime? EndDate { get; set; } // EndDate
        public string Description { get; set; } // Description
        public int IsId { get; set; } // isId (Primary key)
        public int RandevuId { get; set; } // RandevuId (Primary key)
        public string IsiOlusturan { get; set; } // IsiOlusturan (length: 50)
        public string RandevuyuVeren { get; set; } // RandevuyuVeren (length: 50)
    }

}
