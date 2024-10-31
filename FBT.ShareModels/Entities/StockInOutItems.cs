using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public class StockInOutItems: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public int CompanyId { get; set; }
    
    public int SeqNo { get; set; }
    
    public string ItemCD { get; set; }
    
    public double Price { get; set; }
    
    public int Qty { get; set; }
    
    public string Comment { get; set; }

    public string DataKey { get; set; }
}