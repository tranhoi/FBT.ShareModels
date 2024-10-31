using System;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class OrderReturnItem : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }

        [ForeignKey("OrderHeaderId")]
        public Order OrderHeader { get; set; }
        public int CompanyId { get; set; }
        public string OrderId { get; set; }
        public string SalesProductCode { get; set; }
        public string SalesProductName { get; set; }
        public int? ReturnQuantity { get; set; }
        public string DataKey { get; set; }
    }
}