using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourWebApp.Data.Migrations
{
    public partial class totatlspentremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSpent",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalSpent",
                table: "AspNetUsers",
                type: "real",
                nullable: true);
        }
    }
}
