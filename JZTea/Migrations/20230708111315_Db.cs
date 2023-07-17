﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JZTea.Migrations
{
    /// <inheritdoc />
    public partial class Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discount = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    postDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isPublish = table.Column<bool>(type: "bit", nullable: true),
                    categoryID = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                    table.ForeignKey(
                        name: "FK_Product_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    limit = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    productID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.id);
                    table.ForeignKey(
                        name: "FK_Voucher_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { "cream", "Cream" },
                    { "ice drink", "Ice Drink" },
                    { "juice", "Juice" },
                    { "milk tea", "Milk Tea" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "id", "image", "name", "price" },
                values: new object[,]
                {
                    { 1, "tp01.png", "Brown Jelly", 0.5 },
                    { 2, "tp02.png", "Coffee Jelly", 0.5 },
                    { 3, "tp03.png", "Fabric Pearl", 0.5 },
                    { 4, "tp04.png", "Mango Pearl", 0.5 },
                    { 5, "tp05.png", "Vera", 0.5 },
                    { 6, "tp06.png", "Black Pearl", 0.5 },
                    { 7, "tp07.png", "White Pearl", 0.5 },
                    { 8, "tp08.png", "Jelly fruit", 0.5 },
                    { 9, "tp09.png", "Pudding", 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "categoryID", "description", "discount", "image", "isPublish", "name", "postDate", "price" },
                values: new object[,]
                {
                    { 1, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 11, "sp1.png", true, "Okinawa Coffee Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6657), 2.21 },
                    { 2, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 15, "sp2.png", true, "Okinawa Oreo Cream Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6674), 2.21 },
                    { 3, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 10, "sp3.png", true, "Black Pearl Mango Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6677), 2.21 },
                    { 4, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 12, "sp4.png", true, "Okinawa Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6680), 2.21 },
                    { 5, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 10, "sp5.png", true, "Matcha Red Bean Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6683), 2.21 },
                    { 6, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 15, "sp6.png", true, "Oolong Milk Tea 3J", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6686), 2.21 },
                    { 7, "milk tea", "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.", 15, "sp7.png", true, "Red Bean Pudding Milk Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6688), 2.21 },
                    { 8, "cream", "Produced from high quality ingredients in Vietnam and the ice cream recipe is carefully researched according to Vietnamese taste", 0, "sp8.png", true, "Milk Tea & Black Pearl Ice Cream", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6691), 1.48 },
                    { 9, "cream", "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried", 0, "sp9.png", true, "Milk Tea Ice Cream", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6695), 1.48 },
                    { 10, "juice", "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried", 5, "sp10.png", true, "Alisan Fruit Tea", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6697), 1.8 },
                    { 11, "juice", "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried", 5, "sp11.png", true, "Ai-yu Lemon and White Pearl", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6704), 1.8 },
                    { 12, "juice", "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried", 5, "sp12.png", true, "Pink Peach Plum Seeds", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6706), 1.8 },
                    { 13, "juice", "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried", 5, "sp13.png", true, "Pink Peach Plum Seeds", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6717), 1.8 },
                    { 14, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp14.png", true, "Golden Milk Peaches Ice Snow", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6723), 2.1099999999999999 },
                    { 15, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp15.png", true, "Pink Peach Ice Snow", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6730), 2.1099999999999999 },
                    { 16, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp16.png", true, "Strawberry Choco Cookie Smoothie", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6733), 2.1099999999999999 },
                    { 17, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp17.png", true, "Mint Cookie Smoothie", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6736), 2.1099999999999999 },
                    { 18, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp18.png", true, "Strawberry Oreo Smoothie", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6738), 2.1099999999999999 },
                    { 19, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp19.png", true, "Iced Matcha", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6741), 2.1099999999999999 },
                    { 20, "ice drink", "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…", 8, "sp20.png", true, "Yakult Peach Crushed Stone", new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6754), 2.1099999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_productID",
                table: "Voucher",
                column: "productID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
