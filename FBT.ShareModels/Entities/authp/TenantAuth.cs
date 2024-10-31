﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels;

[Table("Tenants")]
public partial class TenantAuth
{
    [Key] public int TenantId { get; set; }

    public string? ParentDataKey { get; set; }

    public string TenantFullName { get; set; }

    public bool? IsHierarchical { get; set; }

    public int? ParentTenantId { get; set; }
    public string? DatabaseInfoName { get; set; }

    public bool? HasOwnDb { get; set; }

   }