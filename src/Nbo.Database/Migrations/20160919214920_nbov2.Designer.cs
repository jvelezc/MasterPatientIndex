using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Nbo.Database.Context;

namespace Nbo.Database.Migrations
{
    [DbContext(typeof(NboCtx))]
    [Migration("20160919214920_nbov2")]
    partial class nbov2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nbo.Database.Entities.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UniqueUserIdentifier");

                    b.HasKey("UserInfoId");

                    b.ToTable("UserInfo");
                });
        }
    }
}
