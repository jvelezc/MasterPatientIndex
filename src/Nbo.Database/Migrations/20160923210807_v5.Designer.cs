using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Nbo.Database.Context;

namespace Nbo.Database.Migrations
{
    [DbContext(typeof(NboCtx))]
    [Migration("20160923210807_v5")]
    partial class v5
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

            modelBuilder.Entity("Nbo.Database.Entities.ApplicationUserDetail", b =>
                {
                    b.Property<int>("ApplicationUserDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsMasterRecord");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName");

                    b.HasKey("ApplicationUserDetailId");

                    b.ToTable("ApplicationUserDetail");
                });

            modelBuilder.Entity("Nbo.Database.Entities.ApplicationUserInfo", b =>
                {
                    b.Property<int>("ApplicationUserInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<int>("MasterUserRecordId");

                    b.HasKey("ApplicationUserInfoId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("MasterUserRecordId");

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

            modelBuilder.Entity("Nbo.Database.Entities.MasterUserRecord", b =>
                {
                    b.Property<int>("MasterUserRecordId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("SoftDeletedBy");

                    b.Property<DateTime?>("SoftDeletedDate");

                    b.Property<string>("UniqueUserIdentifier");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("MasterUserRecordId");

                    b.ToTable("MasterUserRecord");
                });

            modelBuilder.Entity("Nbo.Database.Entities.ApplicationUserInfo", b =>
                {
                    b.HasOne("Nbo.Database.Entities.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nbo.Database.Entities.MasterUserRecord", "MasterUserRecord")
                        .WithMany()
                        .HasForeignKey("MasterUserRecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nbo.Database.Entities.MarketingAction", b =>
                {
                    b.HasOne("Nbo.Database.Entities.ActionType", "ActionType")
                        .WithMany("MarketingAction")
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
