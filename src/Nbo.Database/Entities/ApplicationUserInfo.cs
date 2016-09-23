namespace Nbo.Database.Entities
{
    public class ApplicationUserInfo
    {
        public int ApplicationUserInfoId { get; set; }
        public int ApplicationId { get; set; }
        public int MasterUserRecordId { get; set; }
        public Application Application { get; set; }
        public MasterUserRecord MasterUserRecord { get; set; }
    }
}
