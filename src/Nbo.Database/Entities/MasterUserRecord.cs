using Nbo.Database.BaseClasses;
using System.Collections.Generic;

namespace Nbo.Database.Entities
{
    public class MasterUserRecord : AuditFields
    {
        public int MasterUserRecordId { get; set; }
        public string UniqueUserIdentifier { get; set; }
        public ICollection<ApplicationUserInfo> ApplicationUserInfo { get; set; }
    }
}
