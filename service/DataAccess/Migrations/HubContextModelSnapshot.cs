// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(HubContext))]
    partial class HubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entity.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = 0L,
                            Name = "Student",
                            Updated = 0L
                        },
                        new
                        {
                            Id = 2,
                            Created = 0L,
                            Name = "Business",
                            Updated = 0L
                        },
                        new
                        {
                            Id = 3,
                            Created = 0L,
                            Name = "Manager",
                            Updated = 0L
                        },
                        new
                        {
                            Id = 4,
                            Created = 0L,
                            Name = "Admin",
                            Updated = 0L
                        });
                });

            modelBuilder.Entity("Core.Entity.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = 0L,
                            OperationClaimId = 4,
                            Updated = 0L,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entity.Concrete.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<int>("DepartmentCodeId")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentCodeId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = 0L,
                            DepartmentCodeId = 1,
                            FacultyId = 1,
                            Updated = 0L
                        });
                });

            modelBuilder.Entity("Entity.Concrete.DepartmentCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("DepartmentCodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = 0L,
                            Name = "Bilgisayar mühendisliği",
                            Updated = 0L
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Altitude")
                        .HasColumnType("double");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Çorlu, silahtarağa mah.",
                            Altitude = 21.213124000000001,
                            Created = 0L,
                            Latitude = 43.213411999999998,
                            Name = "Çorlu mühendislik",
                            UniversityId = 1,
                            Updated = 0L
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Entity.Concrete.PostHasTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostHasTag");
                });

            modelBuilder.Entity("Entity.Concrete.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Entity.Concrete.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<int>("FoundationYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "59",
                            Created = 0L,
                            FoundationYear = 2000,
                            Name = "Namık Kemal",
                            Updated = 0L
                        });
                });

            modelBuilder.Entity("Entity.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = 0L,
                            Email = "berkslv@gmail.com",
                            Name = "Berk Selvi",
                            PasswordHash = new byte[] { 196, 16, 137, 62, 88, 75, 33, 231, 76, 110, 1, 214, 151, 20, 100, 216, 155, 162, 134, 236, 202, 49, 215, 97, 57, 41, 151, 194, 137, 198, 77, 2, 75, 125, 75, 36, 190, 32, 4, 128, 201, 73, 159, 37, 132, 120, 176, 210, 240, 171, 163, 12, 118, 123, 215, 169, 40, 2, 5, 115, 178, 109, 14, 133 },
                            PasswordSalt = new byte[] { 199, 242, 160, 211, 88, 43, 114, 158, 109, 249, 59, 31, 202, 221, 8, 245, 232, 54, 240, 130, 141, 195, 254, 163, 51, 250, 109, 253, 140, 53, 161, 6, 108, 2, 231, 165, 196, 69, 215, 156, 35, 51, 27, 33, 222, 244, 148, 15, 10, 14, 131, 141, 249, 208, 40, 198, 149, 82, 123, 159, 16, 162, 119, 179, 165, 67, 0, 229, 233, 226, 230, 243, 19, 209, 81, 232, 66, 149, 97, 32, 141, 7, 250, 133, 91, 99, 229, 3, 72, 158, 57, 86, 58, 96, 146, 232, 210, 90, 3, 227, 110, 247, 124, 28, 213, 188, 224, 62, 32, 222, 218, 241, 30, 211, 41, 60, 91, 63, 9, 82, 8, 151, 138, 158, 31, 138, 83, 232 },
                            Role = "Admin",
                            Status = true,
                            Updated = 0L,
                            Username = "berkselvi.dev"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.UserCode", b =>
                {
                    b.Property<int>("UserCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserCodeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCodes");
                });

            modelBuilder.Entity("Entity.Concrete.UserDislikeComment", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("UserDislikeComment");
                });

            modelBuilder.Entity("Entity.Concrete.UserDislikePost", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserDislikePost");
                });

            modelBuilder.Entity("Entity.Concrete.UserLikeComment", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("UserLikeComment");
                });

            modelBuilder.Entity("Entity.Concrete.UserLikePost", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<long>("Created")
                        .HasColumnType("bigint");

                    b.Property<long>("Updated")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserLikePost");
                });

            modelBuilder.Entity("Entity.Concrete.Comment", b =>
                {
                    b.HasOne("Entity.Concrete.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Entity.Concrete.Department", b =>
                {
                    b.HasOne("Entity.Concrete.DepartmentCode", "DepartmentCode")
                        .WithMany("Departments")
                        .HasForeignKey("DepartmentCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentCode");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Entity.Concrete.Faculty", b =>
                {
                    b.HasOne("Entity.Concrete.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("Entity.Concrete.Post", b =>
                {
                    b.HasOne("Entity.Concrete.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Entity.Concrete.PostHasTag", b =>
                {
                    b.HasOne("Entity.Concrete.Post", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Tag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Entity.Concrete.User", b =>
                {
                    b.HasOne("Entity.Concrete.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Entity.Concrete.Faculty", "Faculty")
                        .WithMany("Users")
                        .HasForeignKey("FacultyId");

                    b.HasOne("Entity.Concrete.University", "University")
                        .WithMany("Users")
                        .HasForeignKey("UniversityId");

                    b.Navigation("Department");

                    b.Navigation("Faculty");

                    b.Navigation("University");
                });

            modelBuilder.Entity("Entity.Concrete.UserCode", b =>
                {
                    b.HasOne("Entity.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Concrete.UserDislikeComment", b =>
                {
                    b.HasOne("Entity.Concrete.Comment", "Comment")
                        .WithMany("Dislikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.User", "User")
                        .WithMany("DislikedComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Concrete.UserDislikePost", b =>
                {
                    b.HasOne("Entity.Concrete.Post", "Post")
                        .WithMany("Dislikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.User", "User")
                        .WithMany("DislikedPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Concrete.UserLikeComment", b =>
                {
                    b.HasOne("Entity.Concrete.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.User", "User")
                        .WithMany("LikedComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Concrete.UserLikePost", b =>
                {
                    b.HasOne("Entity.Concrete.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.User", "User")
                        .WithMany("LikedPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Concrete.Comment", b =>
                {
                    b.Navigation("Dislikes");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Entity.Concrete.Department", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entity.Concrete.DepartmentCode", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Entity.Concrete.Faculty", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entity.Concrete.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Dislikes");

                    b.Navigation("Likes");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Entity.Concrete.Tag", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Entity.Concrete.University", b =>
                {
                    b.Navigation("Faculties");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entity.Concrete.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("DislikedComments");

                    b.Navigation("DislikedPosts");

                    b.Navigation("LikedComments");

                    b.Navigation("LikedPosts");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
