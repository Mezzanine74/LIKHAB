using LIKHAB.Common;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class IlceViewModel : IId
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il secilmeli")]
        public int IlId { get; set; }
        public string Il { get; set; }
        [Required(ErrorMessage = "Ilce secilmeli")]
        public string Ilce { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}