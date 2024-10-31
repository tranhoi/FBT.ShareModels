using System.ComponentModel.DataAnnotations;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class ChannelMaster: AuditEntityBase, IDataKeyFilter
    { 
        [Key]
        public string ChannelMasterCode { get; set; }
        public string ChannelMasterName { get; set; }
        public string DataKey { get; set; }
    }
}