﻿using System;
using System.ComponentModel.DataAnnotations;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class OrderStatus :AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public string StatusOrder { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string DataKey { get; set; }
    }
}