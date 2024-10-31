using System;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class ProductStatus : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public string StatusProduct { get; set; }
        public string Description { get; set; }
        public string DataKey { get; set; }
    }
}