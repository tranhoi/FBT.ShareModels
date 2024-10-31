using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public class StockLocations: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public string LocationCD { get; set; }
    
    public string LocationName { get; set; }
    public string DataKey { get; set; }
}