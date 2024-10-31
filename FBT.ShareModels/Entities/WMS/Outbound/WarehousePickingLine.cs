using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehousePickingLines")]
public partial class WarehousePickingLine : GenericEntity
{
   [Key] public Guid Id { get; set; }

    public string PickNo { get; set; }

    public string ProductCode { get; set; }

    public string? Location { get; set; }

    public string? Bin { get; set; }

    public string? LotNo { get; set; }

    public double? PickQty { get; set; }

    public double? ActualQty { get; set; }

    public string? CreateOperatorId { get; set; }

    public DateTime? UpdateAt { get; set; }

    public bool? IsDeleted { get; set; }

    public EnumShipmentOrderStatus? Status { get; set; } = EnumShipmentOrderStatus.Draft;

    public int UnitId { get; set; }
}