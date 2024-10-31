﻿using System.ComponentModel.DataAnnotations;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;

public class Currency : AuditEntityBase, IDataKeyFilter
{
    [Key]
    public string CurrencyCode { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
    public bool IsDisplayCurrency { get; set; }
    public string DataKey { get; set; }
}