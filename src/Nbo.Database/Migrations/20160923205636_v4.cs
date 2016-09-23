using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nbo.Database.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserInfo_UserInfo_UserInfoId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserInfo_UserInfoId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.CreateTable(
                name: "ApplicationUserDetail",
                columns: table => new
                {
                    ApplicationUserDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsMasterRecord = table.Column<bool>(nullable: false),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDetail", x => x.ApplicationUserDetailId);
                });

            migrationBuilder.CreateTable(
                name: "MasterUserRecord",
                columns: table => new
                {
                    MasterUserRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UniqueUserIdentifier = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterUserRecord", x => x.MasterUserRecordId);
                });

            migrationBuilder.AddColumn<int>(
                name: "MasterUserRecordId",
                table: "ApplicationUserInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserInfo_MasterUserRecordId",
                table: "ApplicationUserInfo",
                column: "MasterUserRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserInfo_MasterUserRecord_MasterUserRecordId",
                table: "ApplicationUserInfo",
                column: "MasterUserRecordId",
                principalTable: "MasterUserRecord",
                principalColumn: "MasterUserRecordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserInfo_MasterUserRecord_MasterUserRecordId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserInfo_MasterUserRecordId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropColumn(
                name: "MasterUserRecordId",
                table: "ApplicationUserInfo");

            migrationBuilder.DropTable(
                name: "ApplicationUserDetail");

            migrationBuilder.DropTable(
                name: "MasterUserRecord");

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    UserDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsMasterRecord = table.Column<bool>(nullable: false),
                    NewRecordIdPointer = table.Column<string>(nullable: true),
                    RecordKey = table.Column<string>(nullable: true),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.UserDetailId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UniqueUserIdentifier = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserInfoId);
                });

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "ApplicationUserInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserInfo_UserInfoId",
                table: "ApplicationUserInfo",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserInfo_UserInfo_UserInfoId",
                table: "ApplicationUserInfo",
                column: "UserInfoId",
                principalTable: "UserInfo",
                principalColumn: "UserInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
