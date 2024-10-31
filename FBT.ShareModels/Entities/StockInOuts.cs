using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public class StockInOuts: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public int SeqNo { get; set; }
    
    public int CompanyId { get; set; }
    
    public string WarehouseCode { get; set; }
    
    public DateTime StockDate { get; set; }
    
    public string LocationCD { get; set; }
    
    public string InOutCD { get; set; }
    
    public string StockCD { get; set; }
    
    public string OperatorID { get; set; }
    
    public string Comment { get; set; }
    
    public string DataKey { get; set; }
    
}