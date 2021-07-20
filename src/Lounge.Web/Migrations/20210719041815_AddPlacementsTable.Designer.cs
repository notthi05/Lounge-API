﻿// <auto-generated />
using System;
using Lounge.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lounge.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210719041815_AddPlacementsTable")]
    partial class AddPlacementsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PrevMmr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("Lounge.Web.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsStrike")
                        .HasColumnType("bit");

                    b.Property<int>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PrevMmr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("Lounge.Web.Models.Placement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AwardedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mmr")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("PrevMmr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwardedOn");

                    b.HasIndex("PlayerId");

                    b.ToTable("Placements");
                });

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InitialMmr")
                        .HasColumnType("int");

                    b.Property<int>("MKCId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxMmr")
                        .HasColumnType("int");

                    b.Property<int?>("Mmr")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("PlacedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("MKCId")
                        .IsUnique();

                    b.HasIndex("NormalizedName")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Lounge.Web.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumTeams")
                        .HasColumnType("int");

                    b.Property<string>("TableImageData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScore", b =>
                {
                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<double>("Multiplier")
                        .HasColumnType("float");

                    b.Property<int?>("NewMmr")
                        .HasColumnType("int");

                    b.Property<int?>("PrevMmr")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.HasKey("TableId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("TableScores");
                });

            modelBuilder.Entity("Lounge.Web.Models.Bonus", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Bonuses")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.Penalty", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Penalties")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.Placement", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("Placements")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lounge.Web.Models.TableScore", b =>
                {
                    b.HasOne("Lounge.Web.Models.Player", "Player")
                        .WithMany("TableScores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lounge.Web.Models.Table", "Table")
                        .WithMany("Scores")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Lounge.Web.Models.Player", b =>
                {
                    b.Navigation("Bonuses");

                    b.Navigation("Penalties");

                    b.Navigation("Placements");

                    b.Navigation("TableScores");
                });

            modelBuilder.Entity("Lounge.Web.Models.Table", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
