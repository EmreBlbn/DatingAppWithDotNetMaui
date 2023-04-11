﻿// <auto-generated />
using ChatAppApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatAppApi.Migrations
{
    [DbContext(typeof(ChatAppContext))]
    partial class ChatAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChatAppApi.Entities.TblMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<int>("FromUserId")
                        .HasColumnType("integer")
                        .HasColumnName("fromuserid");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean")
                        .HasColumnName("isread");

                    b.Property<string>("SendDateDay")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senddateday");

                    b.Property<string>("SendDateTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senddatetime");

                    b.Property<int>("ToUserId")
                        .HasColumnType("integer")
                        .HasColumnName("touserid");

                    b.HasKey("Id");

                    b.ToTable("tblmessages");
                });

            modelBuilder.Entity("ChatAppApi.Entities.TblUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarFile")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatarfile");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean")
                        .HasColumnName("isonline");

                    b.Property<string>("LastLogonDay")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastlogonday");

                    b.Property<string>("LastLogonTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastlogontime");

                    b.Property<string>("LoginId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("loginid");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("tblusers");
                });

            modelBuilder.Entity("ChatAppApi.Entities.TblUserFriend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FriendId")
                        .HasColumnType("integer")
                        .HasColumnName("friendid");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Id");

                    b.ToTable("tbluserfriends");
                });
#pragma warning restore 612, 618
        }
    }
}
