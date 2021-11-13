using JwtDotNet5Api.Helper;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace JwtDotNet5Api.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns:new[] {"Id","Name", "NormalizedName", "ConcurrencyStamp" },
                values:new object [] {Guid.NewGuid().ToString(),"Admin", Roles.Admin.ToUpper(), Guid.NewGuid().ToString()}     
                );
            migrationBuilder.InsertData(
           table: "AspNetRoles",
           columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
           values: new object[] { Guid.NewGuid().ToString(), "User", Roles.User.ToUpper(), Guid.NewGuid().ToString() }
           );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [AspNetRoles]");
        }
    }
}
