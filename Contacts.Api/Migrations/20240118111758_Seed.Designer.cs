﻿// <auto-generated />
using System;
using Contacts.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contacts.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240118111758_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Contacts.Api.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBookmarked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbe433c5-9d16-4e23-af54-ad06e77d94c4"),
                            Address = "Vukovarska 125, Split",
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3017),
                            FirstName = "Marko",
                            IsBookmarked = false,
                            LastName = "Livaja",
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3017)
                        },
                        new
                        {
                            Id = new Guid("e0ad95a4-a7eb-486d-a9d2-bd59bb659156"),
                            Address = "Put Skalica 25, Split",
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3020),
                            FirstName = "Milan",
                            IsBookmarked = false,
                            LastName = "Rapaić",
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3021)
                        });
                });

            modelBuilder.Entity("Contacts.Api.Models.ContactTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("TagId");

                    b.ToTable("ContactTags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cef90a2c-1d3c-4485-bea1-8f56a4dc0465"),
                            ContactId = new Guid("fbe433c5-9d16-4e23-af54-ad06e77d94c4"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3175),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3175),
                            TagId = new Guid("e4768b3a-fbbd-42ab-83ec-d23e50209772")
                        },
                        new
                        {
                            Id = new Guid("c4197984-53ef-4e0a-9b13-deb2d2c05ca4"),
                            ContactId = new Guid("fbe433c5-9d16-4e23-af54-ad06e77d94c4"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3178),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3179),
                            TagId = new Guid("d0911701-eff2-4c3e-beed-6cb0e2b740ee")
                        },
                        new
                        {
                            Id = new Guid("62211b83-7a50-4655-8740-0b5b4541961a"),
                            ContactId = new Guid("e0ad95a4-a7eb-486d-a9d2-bd59bb659156"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3181),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3182),
                            TagId = new Guid("e4768b3a-fbbd-42ab-83ec-d23e50209772")
                        });
                });

            modelBuilder.Entity("Contacts.Api.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("237a7a2e-798e-4739-a9d0-7ae03ccf56ff"),
                            ContactId = new Guid("fbe433c5-9d16-4e23-af54-ad06e77d94c4"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3134),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3135),
                            Value = "livaja@st.com"
                        },
                        new
                        {
                            Id = new Guid("005e8e78-9535-46f5-8fe7-d3b48db66f04"),
                            ContactId = new Guid("e0ad95a4-a7eb-486d-a9d2-bd59bb659156"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3138),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3139),
                            Value = "miki.rapaic@st.com"
                        });
                });

            modelBuilder.Entity("Contacts.Api.Models.Number", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Numbers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("237a7a2e-798e-4739-a9d0-7ae03ccf56ff"),
                            ContactId = new Guid("fbe433c5-9d16-4e23-af54-ad06e77d94c4"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3156),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3157),
                            Value = "0975549875"
                        },
                        new
                        {
                            Id = new Guid("005e8e78-9535-46f5-8fe7-d3b48db66f04"),
                            ContactId = new Guid("e0ad95a4-a7eb-486d-a9d2-bd59bb659156"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3160),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(3160),
                            Value = "0914563298"
                        });
                });

            modelBuilder.Entity("Contacts.Api.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4768b3a-fbbd-42ab-83ec-d23e50209772"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(2899),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(2902),
                            Value = "posao"
                        },
                        new
                        {
                            Id = new Guid("d0911701-eff2-4c3e-beed-6cb0e2b740ee"),
                            CreationDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(2918),
                            LastUpdateDate = new DateTime(2024, 1, 18, 11, 17, 58, 410, DateTimeKind.Utc).AddTicks(2919),
                            Value = "sport"
                        });
                });

            modelBuilder.Entity("Contacts.Api.Models.ContactTag", b =>
                {
                    b.HasOne("Contacts.Api.Models.Contact", "Contact")
                        .WithMany("ContactTags")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contacts.Api.Models.Tag", "Tag")
                        .WithMany("ContactTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Contacts.Api.Models.Email", b =>
                {
                    b.HasOne("Contacts.Api.Models.Contact", "Contact")
                        .WithMany("Emails")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Contacts.Api.Models.Number", b =>
                {
                    b.HasOne("Contacts.Api.Models.Contact", "Contact")
                        .WithMany("Numbers")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Contacts.Api.Models.Contact", b =>
                {
                    b.Navigation("ContactTags");

                    b.Navigation("Emails");

                    b.Navigation("Numbers");
                });

            modelBuilder.Entity("Contacts.Api.Models.Tag", b =>
                {
                    b.Navigation("ContactTags");
                });
#pragma warning restore 612, 618
        }
    }
}
