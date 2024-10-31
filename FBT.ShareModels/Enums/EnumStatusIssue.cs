namespace FBT.ShareModels
{
    public enum EnumStatusIssue
    {
        None = 0,
        OnOrder = 1, // Warehouse Shipment
        Picked = 2,
        Packing = 3,
        Delivered = 4,
        Cancelled = 5
    }
}
