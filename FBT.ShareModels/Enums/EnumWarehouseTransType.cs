namespace FBT.ShareModels
{
    public enum EnumWarehouseTransType
    {
        Receipt = 0,
        Shipment = 1,

        //use for internal warehouse
        Transfer = 2,
        Movement = 3,
        Adjustment = 4,
        Counting = 5,
        PutAway = 6,
        Picking = 7,
        Packing = 8,
        Return = 9
    }
}
