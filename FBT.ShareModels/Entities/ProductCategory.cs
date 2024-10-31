using FBT.ShareModels.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.Entities;

[Table("ProductCategories")]
public partial class ProductCategory : AuditEntityBase, IDataKeyFilter
{
    [Key]
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public string? Description { get; set; }
    public EnumStatus? Status { get; set; }
    public int? CompanyId { get; set; }
    public string? DataKey { get; set; }

}