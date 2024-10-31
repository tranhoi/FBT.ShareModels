using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    [Table("BatchSchedules")]
    public class BatchSchedule : AuditEntityBase
    {
        [Key]
        public long BatchScheduleId { get; set; }
        public int CompanyId { get; set; }
        public string BatchId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ScheduleDivision { get; set; }
        public DateTime ScheduleTime { get; set; }
        public char ScheduleType { get; set; }
        public char DayOfWeek { get; set; }
    }

}
