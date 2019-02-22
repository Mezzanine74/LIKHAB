using LIKHAB.Common;

namespace LIKHAB.ViewModels
{
    public class HesaplamaViewModel : IId
    {
        public int Id { get; set; }
        public IslerViewModel ModelIsler { get; set; }
        public IsParametreleriViewModel ModelIsParametreleri { get; set; }
        public string MusteriTemsilDurumu { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}