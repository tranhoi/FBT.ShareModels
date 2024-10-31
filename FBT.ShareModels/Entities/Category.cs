
using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public partial class Category: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public string CategoryName { get; set; }
    
    public int CompanyId { get; set; }
    
    public string DataKey { get; set; }

}