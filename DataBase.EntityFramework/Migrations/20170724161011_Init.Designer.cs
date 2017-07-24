using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170724161011_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Core.Education.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.Core.Education.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("Domain.Core.Education.CertificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.ToTable("CertificationTypes");
                });

            modelBuilder.Entity("Domain.Core.Education.EducationalPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EducationProgramId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("EducationProgramId");

                    b.HasIndex("SubjectId");

                    b.ToTable("EducationalPlans");
                });

            modelBuilder.Entity("Domain.Core.Education.EducationProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AcceptDate");

                    b.Property<bool>("Active");

                    b.Property<int?>("CategoryId");

                    b.Property<int?>("EducationTypeId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("ProgramType");

                    b.Property<string>("StudyType");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EducationTypeId");

                    b.ToTable("EducationPrograms");
                });

            modelBuilder.Entity("Domain.Core.Education.EducationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EducationTypes");
                });

            modelBuilder.Entity("Domain.Core.Education.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("End");

                    b.Property<int>("Grade");

                    b.Property<DateTime>("Start");

                    b.Property<int>("StatementId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatementId");

                    b.HasIndex("UserId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Domain.Core.Education.ExamComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExamId");

                    b.Property<string>("Text");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("ExamComments");
                });

            modelBuilder.Entity("Domain.Core.Education.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid");

                    b.Property<int>("ProgramId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Core.Education.Statement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CertificationId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EducationProgramId");

                    b.Property<int?>("GroupId");

                    b.Property<Guid>("Guid");

                    b.Property<int>("SubjectId");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CertificationId");

                    b.HasIndex("EducationProgramId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("Domain.Core.Education.SubGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SubGroups");
                });

            modelBuilder.Entity("Domain.Core.Education.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssessmentId");

                    b.Property<int?>("Duration");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Domain.Core.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<Guid>("Guid");

                    b.Property<string>("LastName");

                    b.Property<string>("ParentMidleName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Core.User.UserCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Guid");

                    b.Property<string>("Number");

                    b.Property<string>("PassCode");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCards");
                });

            modelBuilder.Entity("Domain.Core.User.UserComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserComments");
                });

            modelBuilder.Entity("Domain.Core.User.UserContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CloseDate");

                    b.Property<DateTime?>("EducationEnd");

                    b.Property<int>("EducationProgramId");

                    b.Property<DateTime?>("EducationStart");

                    b.Property<int?>("GroupId");

                    b.Property<Guid>("Guid");

                    b.Property<DateTime>("OpenDate");

                    b.Property<double?>("Pay");

                    b.Property<string>("Result");

                    b.Property<int?>("SubGroupId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EducationProgramId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserContracts");
                });

            modelBuilder.Entity("Domain.Core.User.UserLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Post");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserLocations");
                });

            modelBuilder.Entity("Domain.Core.User.UserPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("Domain.Core.User.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<bool>("Excellent");

                    b.Property<string>("Gender");

                    b.Property<string>("Phone");

                    b.Property<string>("Skype");

                    b.Property<int>("UserId");

                    b.Property<string>("WWW");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Domain.Core.Education.CertificationType", b =>
                {
                    b.HasOne("Domain.Core.Education.Certification", "Assessment")
                        .WithMany("AssessmentTypeList")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.EducationalPlan", b =>
                {
                    b.HasOne("Domain.Core.Education.EducationProgram", "EducationProgram")
                        .WithMany("EducationalPlanList")
                        .HasForeignKey("EducationProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Education.Subject", "Subject")
                        .WithMany("EducationalPlanList")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.EducationProgram", b =>
                {
                    b.HasOne("Domain.Core.Education.Category", "Category")
                        .WithMany("Programs")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Domain.Core.Education.EducationType", "EducationType")
                        .WithMany()
                        .HasForeignKey("EducationTypeId");
                });

            modelBuilder.Entity("Domain.Core.Education.Exam", b =>
                {
                    b.HasOne("Domain.Core.Education.Statement", "Statement")
                        .WithMany("Exams")
                        .HasForeignKey("StatementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany("Exams")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Domain.Core.Education.ExamComment", b =>
                {
                    b.HasOne("Domain.Core.Education.Exam", "Exam")
                        .WithMany("Comments")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany("ExamComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.Group", b =>
                {
                    b.HasOne("Domain.Core.Education.EducationProgram", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.Statement", b =>
                {
                    b.HasOne("Domain.Core.Education.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("CertificationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Education.EducationProgram", "EducationProgram")
                        .WithMany()
                        .HasForeignKey("EducationProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Education.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Domain.Core.Education.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.SubGroup", b =>
                {
                    b.HasOne("Domain.Core.Education.Group", "Group")
                        .WithMany("SubGroupList")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.Education.Subject", b =>
                {
                    b.HasOne("Domain.Core.Education.Certification", "Assessment")
                        .WithMany()
                        .HasForeignKey("AssessmentId");
                });

            modelBuilder.Entity("Domain.Core.User.UserCard", b =>
                {
                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.User.UserComment", b =>
                {
                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany("UserComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.User.UserContract", b =>
                {
                    b.HasOne("Domain.Core.Education.EducationProgram", "EducationProgram")
                        .WithMany()
                        .HasForeignKey("EducationProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Core.Education.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Domain.Core.Education.SubGroup", "SubGroup")
                        .WithMany()
                        .HasForeignKey("SubGroupId");

                    b.HasOne("Domain.Core.User.User", "User")
                        .WithMany("Contracts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.User.UserLocation", b =>
                {
                    b.HasOne("Domain.Core.User.User", "User")
                        .WithOne("Location")
                        .HasForeignKey("Domain.Core.User.UserLocation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.User.UserPhoto", b =>
                {
                    b.HasOne("Domain.Core.User.User", "User")
                        .WithOne("Photo")
                        .HasForeignKey("Domain.Core.User.UserPhoto", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Core.User.UserProfile", b =>
                {
                    b.HasOne("Domain.Core.User.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Domain.Core.User.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
