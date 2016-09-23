using Microsoft.EntityFrameworkCore;
using Nbo.Database.Entities;

namespace Nbo.Database.Context
{
    /// <summary>
    /// The purpose of this class is to register all entities for entity framework to be able to create the tables and relationships neccesary in the database. 
    /// </summary>
    public partial class NboCtx : DbContext
    {
        public DbSet<ActionType> ActionType { get; set; }

        public DbSet<Application> Application { get; set; }
        public DbSet<ApplicationUserDetail> ApplicationUserDetail { get; set; }
        public DbSet<ApplicationUserInfo> ApplicationUserInfo { get; set; }
        public DbSet<MarketingAction> MarketingAction { get; set; }

        public DbSet<MasterUserRecord> MasterUserRecord { get; set; }
        

    }
}
