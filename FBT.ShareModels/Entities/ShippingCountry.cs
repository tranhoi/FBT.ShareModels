using System;
using System.ComponentModel.DataAnnotations;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class ShippingCountry : AuditEntityBase, IDataKeyFilter
    {
        [Key]
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string DisplayName { get; set; }
        public int? DisplayOrder { get; set; }
        public string DataKey { get; set; }
    }
}