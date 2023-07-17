﻿// <auto-generated />
using System;
using JZTea.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JZTea.Migrations
{
    [DbContext(typeof(JZTeaContext))]
    partial class JZTeaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JZTea.Models.Category", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = "milk tea",
                            icon = "ic01.png",
                            name = "Milk Tea"
                        },
                        new
                        {
                            id = "cream",
                            icon = "ic02.png",
                            name = "Cream"
                        },
                        new
                        {
                            id = "juice",
                            icon = "ic03.png",
                            name = "Juice"
                        },
                        new
                        {
                            id = "ice drink",
                            icon = "ic04.png",
                            name = "Ice Drink"
                        });
                });

            modelBuilder.Entity("JZTea.Models.Product", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<string>("categoryID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("discount")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isPublish")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("postDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 11,
                            image = "sp1.png",
                            isPublish = true,
                            name = "Okinawa Coffee Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9854),
                            price = 2.21
                        },
                        new
                        {
                            id = 2,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 15,
                            image = "sp2.png",
                            isPublish = true,
                            name = "Okinawa Oreo Cream Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9867),
                            price = 2.21
                        },
                        new
                        {
                            id = 3,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 10,
                            image = "sp3.png",
                            isPublish = true,
                            name = "Black Pearl Mango Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9870),
                            price = 2.21
                        },
                        new
                        {
                            id = 4,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 12,
                            image = "sp4.png",
                            isPublish = true,
                            name = "Okinawa Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9873),
                            price = 2.21
                        },
                        new
                        {
                            id = 5,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 10,
                            image = "sp5.png",
                            isPublish = true,
                            name = "Matcha Red Bean Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9876),
                            price = 2.21
                        },
                        new
                        {
                            id = 6,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 15,
                            image = "sp6.png",
                            isPublish = true,
                            name = "Oolong Milk Tea 3J",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9878),
                            price = 2.21
                        },
                        new
                        {
                            id = 7,
                            categoryID = "milk tea",
                            description = "Coffee Milk Tea is inherently an addictive drink for office workers who just love fragrant milk tea but need coffee to stay awake all day long at work. This product is more creative with the combination of Okinawa brown sugar ingredients to bring a mild sweet taste, enhancing the flavor of coffee and milk tea.",
                            discount = 15,
                            image = "sp7.png",
                            isPublish = true,
                            name = "Red Bean Pudding Milk Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9881),
                            price = 2.21
                        },
                        new
                        {
                            id = 8,
                            categoryID = "cream",
                            description = "Produced from high quality ingredients in Vietnam and the ice cream recipe is carefully researched according to Vietnamese taste",
                            discount = 0,
                            image = "sp8.png",
                            isPublish = true,
                            name = "Milk Tea & Black Pearl Ice Cream",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9884),
                            price = 1.48
                        },
                        new
                        {
                            id = 9,
                            categoryID = "cream",
                            description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                            discount = 0,
                            image = "sp9.png",
                            isPublish = true,
                            name = "Milk Tea Ice Cream",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9886),
                            price = 1.48
                        },
                        new
                        {
                            id = 10,
                            categoryID = "juice",
                            description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                            discount = 5,
                            image = "sp10.png",
                            isPublish = true,
                            name = "Alisan Fruit Tea",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9889),
                            price = 1.8
                        },
                        new
                        {
                            id = 11,
                            categoryID = "juice",
                            description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                            discount = 5,
                            image = "sp11.png",
                            isPublish = true,
                            name = "Ai-yu Lemon and White Pearl",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9891),
                            price = 1.8
                        },
                        new
                        {
                            id = 12,
                            categoryID = "juice",
                            description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                            discount = 5,
                            image = "sp12.png",
                            isPublish = true,
                            name = "Pink Peach Plum Seeds",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9894),
                            price = 1.8
                        },
                        new
                        {
                            id = 13,
                            categoryID = "juice",
                            description = "Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried",
                            discount = 5,
                            image = "sp13.png",
                            isPublish = true,
                            name = "Pink Peach Plum Seeds",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9897),
                            price = 1.8
                        },
                        new
                        {
                            id = 14,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp14.png",
                            isPublish = true,
                            name = "Golden Milk Peaches Ice Snow",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9899),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 15,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp15.png",
                            isPublish = true,
                            name = "Pink Peach Ice Snow",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9902),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 16,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp16.png",
                            isPublish = true,
                            name = "Strawberry Choco Cookie Smoothie",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9904),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 17,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp17.png",
                            isPublish = true,
                            name = "Mint Cookie Smoothie",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9908),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 18,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp18.png",
                            isPublish = true,
                            name = "Strawberry Oreo Smoothie",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9911),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 19,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp19.png",
                            isPublish = true,
                            name = "Iced Matcha",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 856, DateTimeKind.Local).AddTicks(42),
                            price = 2.1099999999999999
                        },
                        new
                        {
                            id = 20,
                            categoryID = "ice drink",
                            description = "The first iced soft drink consisted of a cup of ice covered with a flavoured syrup. Sophisticated dispensing machines now blend measured quantities of syrup with carbonated or plain water to make the finished beverage. To obtain the soft ice, or slush,…",
                            discount = 8,
                            image = "sp20.png",
                            isPublish = true,
                            name = "Yakult Peach Crushed Stone",
                            postDate = new DateTime(2023, 7, 8, 22, 5, 59, 856, DateTimeKind.Local).AddTicks(45),
                            price = 2.1099999999999999
                        });
                });

            modelBuilder.Entity("JZTea.Models.Topping", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Topping");

                    b.HasData(
                        new
                        {
                            id = 1,
                            image = "tp01.png",
                            name = "Brown Jelly",
                            price = 0.5
                        },
                        new
                        {
                            id = 2,
                            image = "tp02.png",
                            name = "Coffee Jelly",
                            price = 0.5
                        },
                        new
                        {
                            id = 3,
                            image = "tp03.png",
                            name = "Fabric Pearl",
                            price = 0.5
                        },
                        new
                        {
                            id = 4,
                            image = "tp04.png",
                            name = "Mango Pearl",
                            price = 0.5
                        },
                        new
                        {
                            id = 5,
                            image = "tp05.png",
                            name = "Vera",
                            price = 0.5
                        },
                        new
                        {
                            id = 6,
                            image = "tp06.png",
                            name = "Black Pearl",
                            price = 0.5
                        },
                        new
                        {
                            id = 7,
                            image = "tp07.png",
                            name = "White Pearl",
                            price = 0.5
                        },
                        new
                        {
                            id = 8,
                            image = "tp08.png",
                            name = "Jelly fruit",
                            price = 0.5
                        },
                        new
                        {
                            id = 9,
                            image = "tp09.png",
                            name = "Pudding",
                            price = 0.5
                        });
                });

            modelBuilder.Entity("JZTea.Models.Voucher", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("limit")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productID");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("JZTea.Models.Product", b =>
                {
                    b.HasOne("JZTea.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryID");

                    b.Navigation("category");
                });

            modelBuilder.Entity("JZTea.Models.Voucher", b =>
                {
                    b.HasOne("JZTea.Models.Product", "product")
                        .WithMany("vouchers")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("JZTea.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("JZTea.Models.Product", b =>
                {
                    b.Navigation("vouchers");
                });
#pragma warning restore 612, 618
        }
    }
}