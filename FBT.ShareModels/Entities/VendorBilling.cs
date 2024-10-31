using FBT.ShareModels.WMS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels
{
    [Table("VendorBilling")]
    public class VendorBilling : GenericEntity
    {
        [Key] public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? VendorCode { get; set; }
        public string? BillingPeriod { get; set; }
        public double? Total { get; set; } = 0;
        public string? DataKey { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Activated;
    }
}
