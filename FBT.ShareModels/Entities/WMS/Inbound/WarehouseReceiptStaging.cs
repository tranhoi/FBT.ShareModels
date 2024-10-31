using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehouseReceiptStaging")]
public class WarehouseReceiptStaging : GenericEntity
{
    [Key] public Guid Id { get; set; }

    public string ReceiptNo { get; set; }

    public string ProductCode { get; set; }

    public int UnitId { get; set; }

    public double? OrderQty { get; set; }

    public double? TransQty { get; set; }

    public string Bin { get; set; }

    public string LotNo { get; set; }

    public DateOnly? ExpirationDate { get; set; }
    public Guid ReceiptLineId { get; set; }
    public EnumStatusStaging Status { get; set; } = EnumStatusStaging.Pending;
}