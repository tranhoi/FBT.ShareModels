namespace FBT.ShareModels
{
    public enum EnumShipmentOrderStatus
    {
        Draft = 0,
        Open = 1,
        Picking = 2,
        Picked = 3,
        Packing = 4,
        Completed = 5,
        Cancelled = 6,
        All = 7,//dùng cho việc tìm kiếm, chọn toàn bộ các trạng thái của shipment ở packing list master
    }
}