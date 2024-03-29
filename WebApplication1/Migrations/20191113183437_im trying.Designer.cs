﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191113183437_im trying")]
    partial class imtrying
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("ParentCommentId");

                    b.Property<int>("PostId");

                    b.Property<int>("PostedBy");

                    b.HasKey("Id");

                    b.ToTable("Commentss");
                });

            modelBuilder.Entity("WebApplication1.Models.FriendWith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstPerson");

                    b.Property<DateTime>("Friendaversary");

                    b.Property<int>("SecondPersond");

                    b.HasKey("Id");

                    b.ToTable("FreindsWith");
                });

            modelBuilder.Entity("WebApplication1.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId");

                    b.Property<string>("PostContent")
                        .IsRequired();

                    b.Property<DateTime>("PostedDate");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<bool>("IsPrimary");

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.ToTable("PostImagess");
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId");

                    b.Property<int>("ImageId");

                    b.Property<int>("PostId");

                    b.Property<DateTime>("ReactionDate");

                    b.Property<int>("ReactionType");

                    b.HasKey("Id");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("WebApplication1.Models.ReactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconURL");

                    b.Property<string>("TypeName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("ReactionTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
