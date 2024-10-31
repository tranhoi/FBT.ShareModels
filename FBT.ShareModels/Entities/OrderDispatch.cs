using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class OrderDispatch : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DeliveryId { get; set; }
        public string MarketDeliveryNo { get; set; }
        public string OrderId { get; set; }
        public string TrackingNo { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string ShipmentDate { get; set; }
        public string DispatchStatus { get; set; }
        public bool IsCutOff { get; set; }
        public DateTime? CutoffDate { get; set; }
        public string CutoffId { get; set; }
        public bool IsMarketShipped { get; set; }
        public List<OrderDispatchProduct> OrderDispatchProducts { get; set; }
        public string DataKey { get; set; }

        public OrderDispatch()
        {
            OrderDispatchProducts = new List<OrderDispatchProduct>();
        }
    }
}