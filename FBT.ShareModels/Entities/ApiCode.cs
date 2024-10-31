using System;
using System.ComponentModel.DataAnnotations;
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class ApiCode : AuditEntityBase,  IDataKeyFilter
    {
        private ApiCode() { } //needed by EF Core
        [Key]
        public string Code { get; set; }
        public string Message { get; set; }
        public string DataKey { get; set; }
    }
}