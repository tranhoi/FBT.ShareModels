using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    [Table("TaskSchedules")]
    public class TaskSchedule : AuditEntityBase
    {
        [Key]
        public int ScheduleId { get; set; }
        public DateTime ScheduleDatetime { get; set; }
        public int CompanyId { get; set; }
        public string MarketplaceCode { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? FinishDatetime { get; set; }
        public int BatchId { get; set; }
        public int Priority { get; set; }
        public bool IsFailed { get; set; }
        public bool IsStopped { get; set; }
        public string RequestId { get; set; }
        public bool IsBatchInRequest { get; set; }
    }

}
