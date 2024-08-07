using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesManager.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CitiesData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CitiesData",
                columns: new[] { "Id", "CityName" },
                values: new object[,]
                {
                    { new Guid("7321012a-1a9a-4ef0-9999-e2f84988196d"), "USA" },
                    { new Guid("c2deb2aa-d4ca-4b6b-aef5-3962454ac3a3"), "New york" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitiesData");
        }
    }
}
