using System.ComponentModel;

namespace FBT.ShareModels
{
    public enum EnumStatusShipment
    {
        [Description("Draft")]
        Draft = 0,
        [Description("Open")]
        Open = 1,
        [Description("Picking")]
        Picking = 2,
    }
}
