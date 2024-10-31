using System;
using System.ComponentModel.DataAnnotations;

using FBT.ShareModels.Commons;

namespace FBT.Domain.Models
{
    public class ThirdPLWarehouse : AuditEntityBase,IDataKeyFilter
    {
        [Key]
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string Location { get; set; }
        public string DataKey { get; set; }
    }
}