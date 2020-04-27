using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastShop.BackOffice.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    Qtd = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Name", "Document" },
                values: new object[] { 1, "João", "28571987017" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Name", "Document" },
                values: new object[] { 2, "Maria", "39681706013" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price", "CreateAt", "UpdateAt" },
                values: new object[] { 1, "Celular",1000.00, DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(-3) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price", "CreateAt", "UpdateAt" },
                values: new object[] { 2, "Notebook", 3000.00, DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(-3) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price", "CreateAt", "UpdateAt" },
                values: new object[] { 3, "Impressora", 1000.00, DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(-3) });



            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "PaymentType", "Status", "CreateAt", "UpdateAt", "ClientId" },
                values: new object[] { 1, 1, 1, DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(-3), 1 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "PaymentType", "Status", "CreateAt", "UpdateAt", "ClientId" },
                values: new object[] { 2, 1, 1, DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(-3), 2 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ProductId", "OrderId", "Qtd" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ProductId", "OrderId", "Qtd" },
                values: new object[] { 2, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ProductId", "OrderId", "Qtd" },
                values: new object[] { 3, 3, 1, 3 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ProductId", "OrderId", "Qtd" },
                values: new object[] { 4, 1, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ProductId", "OrderId", "Qtd" },
                values: new object[] { 5, 3, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
