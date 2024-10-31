using FBT.ShareModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBT.ShareModels.Entities
{
    public class FdaRegistration : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string DataKey { get; set; }

        public string OrderId { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public int RegistrationStatus { get; set; }

        public string PriorNoticeConfirmationNumber { get; set; }

    }
}
