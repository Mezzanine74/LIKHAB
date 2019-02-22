using LIKHAB.Common;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class KoyMahalleViewModel : IId
    {
        public int Id { get; set; }
        public string Il { get; set; }

        [Required(ErrorMessage = "Ilce secilmeli")]
        public int IlceId { get; set; }
        public string Ilce { get; set; }

        [Required(ErrorMessage = "Koy ve Mahalle secilmeli")]
        public string KoyMahalle { get; set; }

        [Required(ErrorMessage = "Yol kilometre secilmeli")]
        [RegularExpression(@"([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)", ErrorMessage = "Yol kilometre sayi olmali")]
        public decimal YolKilometre { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}