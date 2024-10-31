using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehousePickingList")]
public partial class WarehousePickingList : GenericEntity
{
    [Key] public Guid Id { get; set; }

    public string PickNo { get; set; }

    public int? TenantId { get; set; }

    public string? Location { get; set; }

    public string? PersonInCharge { get; set; }

    public DateOnly? PickedDate { get; set; }

    public string? CreateOperatorId { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateOperatorId { get; set; }

    public DateTime? UpdateAt { get; set; }

    public bool? IsDeleted { get; set; }

    public EnumShipmentOrderStatus? Status { get; set; } = EnumShipmentOrderStatus.Draft;

    public DateOnly? EstimatedShipDate { get; set; }
    public string? Remarks { get; set; }
}