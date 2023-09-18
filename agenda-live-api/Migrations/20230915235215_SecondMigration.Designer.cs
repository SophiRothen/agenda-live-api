﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using agenda_live_api.infraestrutura;

#nullable disable

namespace agenda_live_api.Migrations
{
    [DbContext(typeof(ConnectionContext))]
    [Migration("20230915235215_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("agenda_live_api.Domain.Models.Live", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("channelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liveLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liveName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("liveTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Lives");
                });
#pragma warning restore 612, 618
        }
    }
}
