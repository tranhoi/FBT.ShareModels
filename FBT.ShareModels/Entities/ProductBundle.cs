using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities;
public partial class ProductBundle: AuditEntityBase, IDataKeyFilter
{ 
    
    public int Id { get; set; }
    
    public string SaleProductBundleCode { get; set; }
    
    public string ProductBundleCode { get; set; }
    
    public string ProductCode { get; set; }
    
    public int CompanyId { get; set; }
    
    public int Quantity { get; set; }
    
    public int BundlePriceRatio { get; set; }
    
    public DateTime? StartTime { get; set; }
    
    public DateTime? EndTime { get; set; }
    
    public int ChildProductStatus { get; set; }
    
    public string DataKey { get; set; }

}