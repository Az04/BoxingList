﻿// <auto-generated />
using BoxingList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoxingList.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190515055450_AddBoxerToDatabase")]
    partial class AddBoxerToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoxingList.Models.Boxer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Division");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Record");

                    b.HasKey("Id");

                    b.ToTable("Boxers");
                });
#pragma warning restore 612, 618
        }
    }
}