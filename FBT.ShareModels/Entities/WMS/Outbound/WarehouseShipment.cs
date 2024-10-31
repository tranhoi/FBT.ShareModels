using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehouseShipments")]
public partial class WarehouseShipment : GenericEntity
{
    [Key] public Guid Id { get; set; }

    public string ShipmentNo { get; set; }

    public string? SalesNo { get; set; }

    public int TenantId { get; set; }

    public string? Location { get; set; }

    public DateOnly? PlanShipDate { get; set; }

    public string? PersonInCharge { get; set; }

    public string? ShippingCarrierCode { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Telephone { get; set; }

    public string? TrackingNo { get; set; }

    public string? Email { get; set; }
    public EnumShipmentOrderStatus? Status { get; set; } = EnumShipmentOrderStatus.Draft;
    public string? PickingNo { get; set; }
    public string? LocationName { get; set; }

    public string? TenantName { get; set; }

    public string? PersonInChargeName { get; set; }
    public string? BinId { get; set; }
    public string? Address { get; set; }
}