// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLSV.Models;

#nullable disable

namespace QLSV.Migrations
{
    [DbContext(typeof(DormDbContext))]
    [Migration("20220717144509_Init_relationship_User_Historyrent_Room")]
    partial class Init_relationship_User_Historyrent_Room
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QLSV.Models.HistoryRent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("HistoryRents");
                });

            modelBuilder.Entity("QLSV.Models.RelativeUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RelativeUsers");
                });

            modelBuilder.Entity("QLSV.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DueDateRent")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoryRentId")
                        .HasColumnType("int");

                    b.Property<string>("Semeter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateRent")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HistoryRentId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("QLSV.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Block")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("QLSV.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QLSV.Models.HistoryRent", b =>
                {
                    b.HasOne("QLSV.Models.User", "User")
                        .WithOne("HistoryRent")
                        .HasForeignKey("QLSV.Models.HistoryRent", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("QLSV.Models.RelativeUser", b =>
                {
                    b.HasOne("QLSV.Models.User", null)
                        .WithMany("RelativeUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLSV.Models.Rent", b =>
                {
                    b.HasOne("QLSV.Models.HistoryRent", null)
                        .WithMany("Rents")
                        .HasForeignKey("HistoryRentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLSV.Models.HistoryRent", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("QLSV.Models.User", b =>
                {
                    b.Navigation("HistoryRent");

                    b.Navigation("RelativeUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
