﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Data;

namespace Web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221109105859_add_project_table")]
    partial class add_project_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Web.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Performer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectManagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectManagerId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Web.Models.Person", b =>
                {
                    b.HasOne("Web.Models.Project", null)
                        .WithMany("ProjectExecutors")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Web.Models.Project", b =>
                {
                    b.HasOne("Web.Models.Person", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Web.Models.Person", "ProjectManager")
                        .WithMany()
                        .HasForeignKey("ProjectManagerId");

                    b.Navigation("Employee");

                    b.Navigation("ProjectManager");
                });

            modelBuilder.Entity("Web.Models.Project", b =>
                {
                    b.Navigation("ProjectExecutors");
                });
#pragma warning restore 612, 618
        }
    }
}
