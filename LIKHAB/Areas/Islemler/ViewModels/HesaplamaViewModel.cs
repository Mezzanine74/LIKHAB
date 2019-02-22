namespace LIKHAB.Areas.Islemler.ViewModels
{
    public class HesaplamaViewModel
    {
        public LIKHAB.Models.db.Isler ModelIsler { get; set; }
        public LIKHAB.Models.db.IsParametreleri ModelIsParametreleri { get; set; }
        public string MusteriTemsilDurumu { get; set; }
    }
}