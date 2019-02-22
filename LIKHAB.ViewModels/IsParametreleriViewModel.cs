using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;

namespace LIKHAB.ViewModels
{
    public class IsParametreleriViewModel : IId, IIsParametreleri
    {
        public int Id { get; set; }
        public int Is { get; set; }
        public decimal? YuzOlcumu { get; set; }
        public int? AplikasyonKrokisiSayisi { get; set; }
        public int? ParselSayisi { get; set; }
        public int? NoktaSayisi { get; set; }
        public decimal? ParselAlani { get; set; }
        public decimal? BinaTabanAlani { get; set; }
        public decimal? InsaatAlani { get; set; }
        public int? BagimsizBolumSayisi { get; set; }
        public int? BinaSayisi { get; set; }
        public int? PlanOrnegi { get; set; }
        public int? KatSayisi { get; set; }
        public int? BBolum { get; set; }
        public decimal? OdaKatsayi { get; set; }
        public bool? AraziyeGidilecekmi { get; set; }
        public bool? AyniKisiyeAit { get; set; }
        public bool? OdaBirimFiyatlariniKullan { get; set; }
        public bool? Yuzde50CarpanUygula { get; set; }
        public decimal? YolUcreti { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}