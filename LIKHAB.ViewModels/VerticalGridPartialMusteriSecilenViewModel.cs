using LIKHAB.Common;

namespace LIKHAB.ViewModels
{
    public class VerticalGridPartialMusteriSecilenViewModel : IId
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string TCkimlik_VergiNo { get; set; }
        public string MusteriTemsilDurumu { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}