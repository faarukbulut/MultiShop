﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiShop.Message.DAL.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MultiShop.Message.Migrations
{
    [DbContext(typeof(MessageContext))]
    [Migration("20240424221851_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MultiShop.Message.DAL.Entities.UserMessage", b =>
                {
                    b.Property<int>("UserMessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserMessageID"));

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MessageDetail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isRead")
                        .HasColumnType("boolean");

                    b.HasKey("UserMessageID");

                    b.ToTable("UserMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
