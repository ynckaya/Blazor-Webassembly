using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    QuantityOfWindows = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Windows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    WindowId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Windows_WindowId",
                        column: x => x.WindowId,
                        principalTable: "Windows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "Name", "State" },
                values: new object[] { new Guid("b45ba972-743f-4eec-9e90-4f95b8f5e4ef"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4650), "New York Building 1", "NY" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "Name", "State" },
                values: new object[] { new Guid("fba58d08-0ef0-4242-8d2b-86e9fc75613b"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4690), "California Hotel AJK", "CA" });

            migrationBuilder.InsertData(
                table: "Windows",
                columns: new[] { "Id", "CreatedDate", "Name", "OrderId", "QuantityOfWindows" },
                values: new object[] { new Guid("0acbce03-0400-4ffc-ac99-c6409a12c092"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4700), "A51", new Guid("b45ba972-743f-4eec-9e90-4f95b8f5e4ef"), 4 });

            migrationBuilder.InsertData(
                table: "Windows",
                columns: new[] { "Id", "CreatedDate", "Name", "OrderId", "QuantityOfWindows" },
                values: new object[] { new Guid("0b236432-92be-4890-bdc5-84a27279b1d3"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4740), "OHF", new Guid("fba58d08-0ef0-4242-8d2b-86e9fc75613b"), 10 });

            migrationBuilder.InsertData(
                table: "Windows",
                columns: new[] { "Id", "CreatedDate", "Name", "OrderId", "QuantityOfWindows" },
                values: new object[] { new Guid("35ea7fd9-c332-4a92-8018-83850c9b6325"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4730), "C Zone 5", new Guid("b45ba972-743f-4eec-9e90-4f95b8f5e4ef"), 2 });

            migrationBuilder.InsertData(
                table: "Windows",
                columns: new[] { "Id", "CreatedDate", "Name", "OrderId", "QuantityOfWindows" },
                values: new object[] { new Guid("bd266222-a2cf-4e2d-93ed-4fd18ae0b3ad"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4730), "GLB", new Guid("fba58d08-0ef0-4242-8d2b-86e9fc75613b"), 3 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("16518b0a-3555-4fba-b84c-55d97eba9dcc"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4760), 1850, "Window", 800, new Guid("0acbce03-0400-4ffc-ac99-c6409a12c092") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("66c55954-d519-4e46-b070-f1ce148e68d5"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4770), 2000, "Window", 1500, new Guid("35ea7fd9-c332-4a92-8018-83850c9b6325") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("6f863bad-29a7-42bc-b24b-fbb7db7b8ec4"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4750), 1850, "Doors", 1200, new Guid("0acbce03-0400-4ffc-ac99-c6409a12c092") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("737274fd-6931-413c-8ab9-cf2855a307bd"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4780), 2200, "Doors", 1400, new Guid("bd266222-a2cf-4e2d-93ed-4fd18ae0b3ad") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("74d82df8-45dd-422b-b802-17ec1cc13033"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4790), 2200, "Window", 600, new Guid("bd266222-a2cf-4e2d-93ed-4fd18ae0b3ad") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("b6c00115-5a33-4c90-b8da-c81d0c8d53ab"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4790), 2000, "Doors", 1500, new Guid("0b236432-92be-4890-bdc5-84a27279b1d3") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("be3d65fd-e324-423d-87c2-d528043c7782"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4800), 2000, "Window", 1500, new Guid("0b236432-92be-4890-bdc5-84a27279b1d3") });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Height", "Type", "Width", "WindowId" },
                values: new object[] { new Guid("d95d2178-2172-4d34-b6cb-1d698bc85068"), new DateTime(2024, 1, 6, 0, 20, 25, 103, DateTimeKind.Local).AddTicks(4770), 1850, "Window", 700, new Guid("0acbce03-0400-4ffc-ac99-c6409a12c092") });

            migrationBuilder.CreateIndex(
                name: "IX_Items_WindowId",
                table: "Items",
                column: "WindowId");

            migrationBuilder.CreateIndex(
                name: "IX_Windows_OrderId",
                table: "Windows",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
