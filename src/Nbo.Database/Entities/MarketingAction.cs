using Nbo.Database.BaseClasses;
namespace Nbo.Database.Entities
{
    public class MarketingAction : AuditFields
    {
        public int MarketingActionId { get; set; }
        public int ApplicationId { get; set; }
        public int ActionTypeId { get; set; }
        public Application Application { get; set; }
        public ActionType ActionType { get; set; }
    }
}