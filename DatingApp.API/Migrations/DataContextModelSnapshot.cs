﻿// <auto-generated />
using System;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("DatingApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("DatingApp.API.Models.service_pending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date_updated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("pending_end")
                        .HasColumnType("TEXT");

                    b.Property<int>("pending_repeat")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("pending_start")
                        .HasColumnType("TEXT");

                    b.Property<int>("repeat_cnt")
                        .HasColumnType("INTEGER");

                    b.Property<int>("service_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("user_updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("service_Pendings");
                });
#pragma warning restore 612, 618
        }
    }
}
