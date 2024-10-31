using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;
namespace FBT.Domain.Models;
public partial class PackageAttachProduct : AuditEntityBase, IDataKeyFilter
{
    public int Id { get; set; }

    public int PackageId { get; set; }

    public string DataKey { get; set; }

    public string AttachProductCode { get; set; }

    public virtual Package Package { get; set; }

    public int Quantity { get; set; }
}