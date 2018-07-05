﻿// <auto-generated />
using FinalProjectB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FinalProjectB.Migrations
{
    [DbContext(typeof(FinalProjectBContext))]
    partial class FinalProjectBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProjectB.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<string>("fName")
                        .IsRequired();

                    b.Property<string>("lName")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("role");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("FinalProjectB.Models.Lead", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.Property<string>("owner");

                    b.Property<int>("phone");

                    b.HasKey("ID");

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("FinalProjectB.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("administrator");

                    b.Property<bool>("user");

                    b.HasKey("ID");

                    b.ToTable("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
