using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public class StockTypes: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public string StockCD { get; set; }
    
    public string StockTypeName { get; set; }
    public string DataKey { get; set; }
    
}