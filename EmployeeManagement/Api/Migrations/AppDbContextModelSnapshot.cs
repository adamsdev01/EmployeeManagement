// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Information Technology"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Humar Resources"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Administration"
                        });
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DOB = new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            EmailAddress = "Poppy.Li@opus.com",
                            FirstName = "Poppy",
                            Gender = 1,
                            LastName = "Li",
                            PhotoPath = "images/personStock.jpg"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DOB = new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            EmailAddress = "Brad.Baskshi@opus.com",
                            FirstName = "Brad",
                            Gender = 0,
                            LastName = "Baskshi",
                            PhotoPath = "images/personStock.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DOB = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            EmailAddress = "Richard.Hendricks@opus.com",
                            FirstName = "Richard",
                            Gender = 0,
                            LastName = "Hendricks",
                            PhotoPath = "images/personStock.jpg"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DOB = new DateTime(1980, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            EmailAddress = "Malcolm.Adekanbi@opus.com",
                            FirstName = "Malcolm",
                            Gender = 0,
                            LastName = "Adekanbi",
                            PhotoPath = "images/personStock.jpg"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DOB = new DateTime(1986, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            EmailAddress = "Elliot.Alderson@opus.com",
                            FirstName = "Elliot",
                            Gender = 0,
                            LastName = "Alderson",
                            PhotoPath = "images/personStock.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
