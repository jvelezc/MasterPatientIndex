using Nbo.Database.BaseClasses;
using System.Collections.Generic;

namespace Nbo.Database.Entities
{
    public class ActionType : AuditFields
    {
        public int ActionTypeId { get; set; }
        public string FriendlyName { get; set; }
        public string Value { get; set; }
        public ICollection<MarketingAction> MarketingAction { get; set; }
    }
}