﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS
{
    [Table("PermissionsTenant")]
    public class PermissionsTenant: GenericEntity
    {
        [Key] public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Activated;
    }
}
