using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class WarehouseUserSetting :AuditEntityBase, IDataKeyFilter
    {
        [Key]
        public string WarehouseUserId { get; set; }
        public int CompanyId { get; set; }
        public string WarehouseCode { get; set; }
        public string DataKey { get; set; }
    }
}