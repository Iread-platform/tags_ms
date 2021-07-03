﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iread_story.DataAccess.Data;

namespace iread_story.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("iread_story.DataAccess.Data.Entity.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.HasIndex("StoryId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("iread_story.DataAccess.Data.Entity.Story", b =>
                {
                    b.Property<int>("StoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AudioId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<int>("CoverId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime");

                    b.Property<int>("StoryLevel")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Writer")
                        .HasColumnType("text");

                    b.HasKey("StoryId");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("iread_story.DataAccess.Data.Entity.Page", b =>
                {
                    b.HasOne("iread_story.DataAccess.Data.Entity.Story", "Story")
                        .WithMany("Pages")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("iread_story.DataAccess.Data.Entity.Story", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
