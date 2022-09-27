﻿// <auto-generated />
using System;
using ArticleWebApplicationTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArticleWebApplicationTest.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    [Migration("20220927125344_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArticleWebApplicationTest.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ArticleSourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfViews")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("ReleaseArticleDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleSourceId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.ArticleSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleSourcePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleSources");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.BadWord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DictionarySourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("WordRating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DictionarySourceId");

                    b.ToTable("BadWords");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseCommentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.DictionarySource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoursePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DictionarySources");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.GoodWord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DictionarySourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("WordRating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DictionarySourceId");

                    b.ToTable("GoodWords");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DesiredArticleRating")
                        .HasColumnType("real");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.HasIndex("UserStatusId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.UserStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserStatuses");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.Article", b =>
                {
                    b.HasOne("ArticleWebApplicationTest.ArticleSource", "ArticleSource")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticleSource");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.BadWord", b =>
                {
                    b.HasOne("ArticleWebApplicationTest.DictionarySource", "DictionarySource")
                        .WithMany("BadWords")
                        .HasForeignKey("DictionarySourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DictionarySource");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.Comment", b =>
                {
                    b.HasOne("ArticleWebApplicationTest.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleWebApplicationTest.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.GoodWord", b =>
                {
                    b.HasOne("ArticleWebApplicationTest.DictionarySource", "DictionarySources")
                        .WithMany("GoodWords")
                        .HasForeignKey("DictionarySourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DictionarySources");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.User", b =>
                {
                    b.HasOne("ArticleWebApplicationTest.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleWebApplicationTest.UserStatus", "UserStatus")
                        .WithMany("User")
                        .HasForeignKey("UserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");

                    b.Navigation("UserStatus");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.ArticleSource", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.DictionarySource", b =>
                {
                    b.Navigation("BadWords");

                    b.Navigation("GoodWords");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.User", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.UserRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ArticleWebApplicationTest.UserStatus", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}