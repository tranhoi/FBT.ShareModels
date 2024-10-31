using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    [Table("Batches")]
    public class Batch : AuditEntityBase
    {
        [Key]
        public string BatchId { get; set; }
        public string BatchName { get; set; }
        public string ExecFile { get; set; }
        public bool StartupStatus { get; set; }
        public string Args { get; set; }
    }
}
