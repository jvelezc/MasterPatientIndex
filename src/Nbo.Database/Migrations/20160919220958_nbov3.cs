using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nbo.Database.Migrations
{
    public partial class nbov3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionType",
                columns: table => new
                {
                    ActionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FriendlyName = table.Column<string>(nullable: true),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionType", x => x.ActionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Applicationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Applicationid);
                });

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
                name: "ApplicationUserInfo",
                columns: table => new
                {
                    ApplicationUserInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: false),
                    UserInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserInfo", x => x.ApplicationUserInfoId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserInfo_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Applicationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserInfo_UserInfo_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfo",
                        principalColumn: "UserInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketingAction",
                columns: table => new
                {
                    MarketingActionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionTypeId = table.Column<int>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    SoftDeletedBy = table.Column<string>(nullable: true),
                    SoftDeletedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingAction", x => x.MarketingActionId);
                    table.ForeignKey(
                        name: "FK_MarketingAction_ActionType_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "ActionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketingAction_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Applicationid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SoftDeletedBy",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SoftDeletedDate",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserInfo_ApplicationId",
                table: "ApplicationUserInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserInfo_UserInfoId",
                table: "ApplicationUserInfo",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAction_ActionTypeId",
                table: "MarketingAction",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingAction_ApplicationId",
                table: "MarketingAction",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "SoftDeletedBy",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "SoftDeletedDate",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UserInfo");

            migrationBuilder.DropTable(
                name: "ApplicationUserInfo");

            migrationBuilder.DropTable(
                name: "MarketingAction");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "ActionType");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
