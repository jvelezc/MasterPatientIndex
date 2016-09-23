using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nbo.Database.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_ApplicationId",
                table: "ApplicationUserDetail",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserDetail_Application_ApplicationId",
                table: "ApplicationUserDetail",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Applicationid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserDetail_Application_ApplicationId",
                table: "ApplicationUserDetail");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserDetail_ApplicationId",
                table: "ApplicationUserDetail");
        }
    }
}
