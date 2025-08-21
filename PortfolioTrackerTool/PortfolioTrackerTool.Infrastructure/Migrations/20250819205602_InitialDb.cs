using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioTrackerTool.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PricePerUnit = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Investments",
                columns: new[] { "Id", "Amount", "AssetType", "Date", "Name", "PricePerUnit", "TransactionType" },
                values: new object[,]
                {
                    { 1, 3, "Crypto", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bitcoin", 32000m, "Buy" },
                    { 2, 10, "Crypto", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethereum", 2000m, "Buy" },
                    { 3, 15, "Metal", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gold", 3300m, "Buy" },
                    { 4, 200, "Stock", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesla", 338m, "Buy" },
                    { 5, 40, "Metal", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver", 1220m, "Buy" },
                    { 6, 85, "Stock", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", 513m, "Buy" },
                    { 7, 440, "Stock", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "IBM", 240m, "Buy" },
                    { 8, 1, "Property", new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apartment", 120000m, "Buy" },
                    { 9, 1, "Property", new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 88000m, "Buy" },
                    { 10, 1, "Property", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garage", 12000m, "Buy" },
                    { 11, 10, "Crypto", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "BNB", 830m, "Buy" },
                    { 12, 14, "Metal", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Platinum", 1300m, "Buy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investments");
        }
    }
}
