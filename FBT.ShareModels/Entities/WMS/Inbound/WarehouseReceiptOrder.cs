using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehouseReceiptOrder")]
public class WarehouseReceiptOrder : GenericEntity
{
    [Key] public Guid Id { get; set; }

    public string ReceiptNo { get; set; }

    public string? VendorCode { get; set; }

    public string Location { get; set; }

    public DateOnly? ExpectedDate { get; set; }

    public string? ArrivalType { get; set; }

    public int TenantId { get; set; }
    public DateOnly? PostedDate { get; set; }
    public string? PostedBy { get; set; }
    public int? ScheduledArrivalNumber { get; set; }
    public string? SupplierCode { get; set; }
    public string? DocumentNo { get; set; }

    [Required]
    public int SupplierId { get; set; }

    public string? PersonInCharge { get; set; }

    public string? ConfirmedBy { get; set; }

    public DateOnly? ConfirmedDate { get; set; }
    public EnumReceiptOrderStatus? Status { get; set; } = EnumReceiptOrderStatus.Draft;
}