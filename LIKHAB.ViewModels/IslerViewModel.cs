using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class IslerViewModel : IId, IIsler
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Isin Cinsi Secilmeli")]
        public int IsinCinsi { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Koyu/Mahallesi Secilmeli")]
        public int KoyuMahallesi { get; set; }
        public int? IsinTuru { get; set; }
        public bool? KadastroyaAsliGibiVerilecek { get; set; }
        public bool? Stopaj { get; set; }
        public bool? Tevkifatli { get; set; }
        public bool? KentselDonusum { get; set; }
        public decimal? YolKilometre { get; set; }
        public bool? YolUcretiniElleGir { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Musteri Secilmeli")]
        public int Musteri { get; set; }
        public string MusteriTemsilDurumu { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}