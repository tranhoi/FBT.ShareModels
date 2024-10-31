using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public partial class ProductJanCode: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public int ProductId { get; set; }
    
    public string JanCode { get; set; }
    
    public string Description { get; set; }
    
    public EnumStatus Status { get; set; }
    
    public string DataKey { get; set; }

}