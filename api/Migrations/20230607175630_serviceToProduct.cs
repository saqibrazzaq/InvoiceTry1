using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class serviceToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillItem_Service_ServiceId",
                table: "BillItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Service_ServiceId",
                table: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "ServiceSalesTax");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "InvoiceItem",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_ServiceId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_ProductId");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ForSale = table.Column<bool>(type: "bit", nullable: false),
                    ForPurchase = table.Column<bool>(type: "bit", nullable: false),
                    BusinessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                });

            migrationBuilder.CreateTable(
                name: "ProductSalesTax",
                columns: table => new
                {
                    ProductSalesTaxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    SalesTaxId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSalesTax", x => x.ProductSalesTaxId);
                    table.ForeignKey(
                        name: "FK_ProductSalesTax_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_ProductSalesTax_SalesTax_SalesTaxId",
                        column: x => x.SalesTaxId,
                        principalTable: "SalesTax",
                        principalColumn: "SalesTaxId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_BusinessId",
                table: "Product",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSalesTax_ProductId",
                table: "ProductSalesTax",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSalesTax_SalesTaxId",
                table: "ProductSalesTax",
                column: "SalesTaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillItem_Product_ServiceId",
                table: "BillItem",
                column: "ServiceId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Product_ProductId",
                table: "InvoiceItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillItem_Product_ServiceId",
                table: "BillItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Product_ProductId",
                table: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "ProductSalesTax");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "InvoiceItem",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_ProductId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_ServiceId");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForPurchase = table.Column<bool>(type: "bit", nullable: false),
                    ForSale = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceSalesTax",
                columns: table => new
                {
                    ServiceSalesTaxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesTaxId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSalesTax", x => x.ServiceSalesTaxId);
                    table.ForeignKey(
                        name: "FK_ServiceSalesTax_SalesTax_SalesTaxId",
                        column: x => x.SalesTaxId,
                        principalTable: "SalesTax",
                        principalColumn: "SalesTaxId");
                    table.ForeignKey(
                        name: "FK_ServiceSalesTax_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Service_BusinessId",
                table: "Service",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSalesTax_SalesTaxId",
                table: "ServiceSalesTax",
                column: "SalesTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSalesTax_ServiceId",
                table: "ServiceSalesTax",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillItem_Service_ServiceId",
                table: "BillItem",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Service_ServiceId",
                table: "InvoiceItem",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId");
        }
    }
}
