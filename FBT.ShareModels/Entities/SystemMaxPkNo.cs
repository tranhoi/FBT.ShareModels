﻿using System;
using System.ComponentModel.DataAnnotations;
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class SystemMaxPKNo : AuditEntityBase
    {
        [Key]
        public string ObjectCode { get; set; }
        public int MaxNo { get; set; }
        public int Digit { get; set; }
        public string Remarks { get; set; }
    }
}