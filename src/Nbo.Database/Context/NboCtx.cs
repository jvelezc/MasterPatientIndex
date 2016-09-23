using Microsoft.EntityFrameworkCore;
namespace Nbo.Database.Context
{
    public partial class NboCtx : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=Nbo;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
