using LIKHAB.Common;
using LIKHAB.DataLayer.Interface;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class IlViewModel : IId, IIli
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il secilmeli")]
        public string Il { get; set; }

        [RegularExpression(@"([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)", ErrorMessage = "Il katsayisi sayi olmali")]
        public decimal IlKatsayisi { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}