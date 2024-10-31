﻿
using FBT.ShareModels.Commons;
using System;

namespace FBT.ShareModels.Entities
{
    public class ExchangeRate : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public string CurrencyCodeFrom { get; set; }
        public string CurrencyCodeTo { get; set; }
        public string Period { get; set; }
        public double Rate { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string DataKey { get; set; }
    }
}