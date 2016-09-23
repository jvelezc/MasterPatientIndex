using Nbo.Database.BaseClasses;

namespace Nbo.Database.Entities
{
    /// <summary>
    /// A RecordKey is a primary key (identity) of the user in another system.
    /// A NewRecordIdPointer sets a refence to a master record. Over time corrections will occur in the system. What matters is that there a way to get to the correct record. 
    /// </summary>
    public class ApplicationUserDetail : AuditFields
    {
       public int ApplicationUserDetailId { get; set; }
       public int ApplicationId { get; set; }

       public string UserName { get; set; }

       public bool IsMasterRecord { get; set; }

       public Application Application { get; set; }
    }
}