using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.Domain.Models;
public partial class TaskModel : AuditEntityBase, IDataKeyFilter
{
     public int Id { get; set; }
    
    public int CompanyId { get; set; }
    
    public string? Title { get; set; }
    
    public int Status { get; set; }
    
    public int Priority { get; set; }
    
    public string? Assignee { get; set; }
    
    public int TaskType { get; set; }
    
    public string? TaskContent { get; set; }
    
    public int FdaRegistrationId { get; set; }
    
    public DateTime? StartTime { get; set; }
    
    public DateTime? EndTime { get; set; }

    public string? DataKey { get; set; }

    public virtual ICollection<TaskChatHistory> TaskChatHistories { get; set; } = new List<TaskChatHistory>();

}