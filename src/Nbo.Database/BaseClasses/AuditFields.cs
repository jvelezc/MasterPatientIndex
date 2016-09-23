using System;

namespace Nbo.Database.BaseClasses
{
    public class AuditFields
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? SoftDeletedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string SoftDeletedBy { get; set; }
    }
}
