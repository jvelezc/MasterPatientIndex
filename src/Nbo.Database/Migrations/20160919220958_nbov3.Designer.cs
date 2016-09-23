using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Nbo.Database.Context;

namespace Nbo.Database.Migrations
{
    [DbContext(typeof(NboCtx))]
    [Migration("20160919220958_nbov3")]
    partial class nbov3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nbo.Database.Entities.ActionType", b =>
                {
                    b.Property<int>("ActionTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FriendlyName");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Value");

                    b.HasKey("ActionTypeId");

                    b.ToTable("ActionType");
                });

            modelBuilder.Entity("Nbo.Database.Entities.Application", b =>
                {
                    b.Property<int>("Applicationid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Applicationid");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Nbo.Database.Entities.ApplicationUserInfo", b =>
                {
                    b.Property<int>("ApplicationUserInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<int>("UserInfoId");

                    b.HasKey("ApplicationUserInfoId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("ApplicationUserInfo");
                });

            modelBuilder.Entity("Nbo.Database.Entities.MarketingAction", b =>
                {
                    b.Property<int>("MarketingActionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActionTypeId");

                    b.Property<int>("ApplicationId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("MarketingActionId");

                    b.HasIndex("ActionTypeId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("MarketingAction");
                });

            modelBuilder.Entity("Nbo.Database.Entities.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsMasterRecord");

                    b.Property<string>("NewRecordIdPointer");

                    b.Property<string>("RecordKey");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName");

                    b.HasKey("UserDetailId");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("Nbo.Database.Entities.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UniqueUserIdentifier");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("UserInfoId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("Nbo.Database.Entities.ApplicationUserInfo", b =>
                {
                    b.HasOne("Nbo.Database.Entities.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nbo.Database.Entities.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nbo.Database.Entities.MarketingAction", b =>
                {
                    b.HasOne("Nbo.Database.Entities.ActionType", "ActionType")
                        .WithMany()
                        .HasForeignKey("ActionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nbo.Database.Entities.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
