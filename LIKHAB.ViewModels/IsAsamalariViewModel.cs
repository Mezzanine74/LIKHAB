using LIKHAB.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace LIKHAB.ViewModels
{
    public class IsAsamalariViewModel : IId
    {
        public int Id { get; set; }
        [Required]
        public int IsId { get; set; }
        public Nullable<bool> Fatura { get; set; }
        public DateTime? FaturaWhen { get; set; }
        public Nullable<bool> Randevu { get; set; }
        public Nullable<System.DateTime> RandevuWhen { get; set; }
        public Nullable<bool> Olcum { get; set; }
        public Nullable<System.DateTime> OlcumWhen { get; set; }
        public Nullable<bool> Kontrol { get; set; }
        public Nullable<System.DateTime> KontrolWhen { get; set; }
        public Nullable<bool> BeldEvrGeldi { get; set; }
        public Nullable<System.DateTime> BeldEvrGeldiWhen { get; set; }
        public Nullable<bool> BeldEvrGitti { get; set; }
        public Nullable<System.DateTime> BeldEvrGittiWhen { get; set; }
        public Nullable<bool> KadEvrGeldi { get; set; }
        public Nullable<System.DateTime> KadEvrGeldiWhen { get; set; }
        public Nullable<bool> KadEvrGitti { get; set; }
        public Nullable<System.DateTime> KadEvrGittiWhen { get; set; }
        public Nullable<bool> ProjeYapildi { get; set; }
        public Nullable<System.DateTime> ProjeYapildiWhen { get; set; }
        public Nullable<bool> OdemeAlindi { get; set; }
        public Nullable<System.DateTime> OdemeAlindiWhen { get; set; }
        public Nullable<bool> IsKapandi { get; set; }
        public Nullable<System.DateTime> IsKapandiWhen { get; set; }
        public string WhoCreated { get; set; }
        public string WhoUpdated { get; set; }
        public Nullable<System.DateTime> WhenCreated { get; set; }
        public Nullable<System.DateTime> WhenUpdated { get; set; }

        public OperationResult Validate()
        {
            return new OperationResult();
        }
    }
}