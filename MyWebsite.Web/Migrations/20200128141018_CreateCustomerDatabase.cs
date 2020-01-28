using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.Web.Migrations
{
    public partial class CreateCustomerDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 128, nullable: false),
                    CustomerSurName = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
