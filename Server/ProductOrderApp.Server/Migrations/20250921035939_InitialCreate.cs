using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductOrderApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420464/airpods_max_2024_blue_pdp_image_position_01__wwen_1.png_fynhc8.jpg", "Apple AirPods Max, latest 2024 model, stunning blue.", "AirPods Max", 12999.00m },
                    { 2, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420464/apple_watch_series_11_42mm_gps_rose_gold_aluminum_sport_band_light_blush_pdp_image_position_1__wwen_zvxhlq.jpg", "Apple Watch Series 11 in elegant rose gold.", "Apple Watch Series 11", 9999.00m },
                    { 3, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/cl_iphone_17_pro_cosmic_orange_pdp_image_position_1__wwen_a0zoer.jpg", "iPhone 17 Pro in cosmic orange finish.", "iPhone 17 Pro", 25999.00m },
                    { 4, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/ipad_pro_11_m4_cellular_space_black_pdp_image_position_1b__wwen_1_1_1_1_1_1_1_1_1_1_3_u1tyrb.png", "iPad Pro in sleek space black.", "iPad Pro", 19999.00m },
                    { 5, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/iphone_16_plus_white_pdp_image_position_1__wwen_1_1_1_yyjkna.png", "iPhone 16 Plus in pristine white.", "iPhone 16 Plus", 21999.99m },
                    { 6, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420466/iphone_16_pro_white_titanium_pdp_image_position_1__gben_1_1_1_1_tlte9z.png", "iPhone 16 Pro in classic white.", "iPhone 16 Pro", 23999.99m },
                    { 7, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/iphone_17_sage_pdp_image_position_1__wwen_ye5iqg.jpg", "iPhone 17 in stylish sage green.", "iPhone 17", 25999.99m },
                    { 8, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420465/iphone_air_light_gold_pdp_image_position_1__wwen_vulaid.jpg", "iPhone Air with a light gold finish.", "iPhone Air", 17999.99m },
                    { 9, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420466/macbook_air_13-in_m4_chip_silver_pure_front_screen__usen_1_1_1_kvqt28.jpg", "MacBook Air in silver, lightweight and powerful.", "MacBook Air", 24999.99m },
                    { 10, "https://res.cloudinary.com/dvxz4yf0l/image/upload/v1758420467/macbook_pro_16-inch_m4_pro_or_max_chip_space_black_pdp_image_position_1__wwen_1_3_pzpp6i.png", "MacBook Pro in space black, high-performance laptop.", "MacBook Pro", 37999.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
