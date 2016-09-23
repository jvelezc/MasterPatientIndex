using Nbo.Database.BaseClasses;
using System.Collections.Generic;


namespace Nbo.Database.Entities
{
    public class Application : AuditFields
    {
        public int Applicationid { get; set; }
        public ICollection<ApplicationUserInfo> ApplicationUserInfo { get; set; }
        public ICollection<MarketingAction> MarketingAction { get; set; }
        public ICollection<ApplicationUserDetail> ApplicationUserDetail { get; set; }
    }
}
