using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.Domain.Models;
public partial class Package : AuditEntityBase, IDataKeyFilter
{
    public int Id { get; set; }

    public string PackageName { get; set; }
    public string OrderChannel { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string ProductCode { get; set; }
	
    public string Description { get; set; }
	
    public string DataKey { get; set; }

    public int CompanyId {get; set; }
	
	public virtual ICollection<PackageAttachProduct> PackageAttachProducts { get; set; }

}