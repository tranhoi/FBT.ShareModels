using System;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class OrderDispatchProduct : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public int DispatchHeaderId { get; set; }
        [ForeignKey("DispatchHeaderId")]
        public OrderDispatch DispatchHeader { get; set; }
        public int CompanyId { get; set; }
        public string DeliveryId { get; set; }
        public string OrderId { get; set; }
        public int? LineNo { get; set; }
        public string ProductSku { get; set; }
        public string ItemName { get; set; }
        public int? ShippedQty { get; set; }
        public int? MarketShippedQty { get; set; }
        public double? Price { get; set; }
        public double? DeclaredValue { get; set; }
        public string DataKey { get; set; }
    }
}