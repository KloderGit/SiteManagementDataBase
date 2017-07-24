using Microsoft.EntityFrameworkCore;
using Domain.Core.Education;
using Domain.Core.User;

namespace EntityFrameworkCore
{
    public class ApplicationContext : DbContext
    {
        #region Описание Учебного плана и групп обучения
            public DbSet<Category> Categories { get; set; }
            public DbSet<EducationalPlan> EducationalPlans { get; set; }
            public DbSet<EducationType> EducationTypes { get; set; }
            public DbSet<Group> Groups { get; set; }
            public DbSet<EducationProgram> EducationPrograms { get; set; }
            public DbSet<SubGroup> SubGroups { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Certification> Certifications { get; set; }
            public DbSet<CertificationType> CertificationTypes { get; set; }
        #endregion

        #region Данные о пользователе
            public DbSet<User> Users { get; set; }
            public DbSet<UserProfile> UserProfile { get; set; }
            public DbSet<UserPhoto> UserPhoto { get; set; }
            public DbSet<UserLocation> UserLocation { get; set; }
            public DbSet<UserCard> UserCards { get; set; }
            public DbSet<UserContract> UserContracts { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ApplicationFPALocal;Trusted_Connection=True;");
        }

    }
}
