using System.Data.Entity;
using UniversityTest.Domain.Models;
using UniversityTest.Persistance.Configurations;

namespace UniversityTest.Persistance
{
	public class UniversityDbContext : DbContext
	{
        public DbSet<AcademicPeriod> AcademicPeriods { get; set; }
        public DbSet<AcademicProgram> AcademicPrograms { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<CandidateRegister> CandidateRegisters { get; set; }
        public DbSet<CandidateType> CandidateTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CivilStatus> CivilStatuses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ModalityType> ModalityTypes { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            new AcademicPeriodConfiguration(modelBuilder.Entity<AcademicPeriod>());
            new AcademicProgramConfiguration(modelBuilder.Entity<AcademicProgram>());
            new BloodTypeConfiguration(modelBuilder.Entity<BloodType>());
            new CampusConfiguration(modelBuilder.Entity<Campus>());
            new CandidateRegisterConfiguration(modelBuilder.Entity<CandidateRegister>());
            new CandidateTypeConfiguration(modelBuilder.Entity<CandidateType>());
            new CityConfiguration(modelBuilder.Entity<City>());
            new CivilStatusConfiguration(modelBuilder.Entity<CivilStatus>());
            new CountryConfiguration(modelBuilder.Entity<Country>());
            new DepartmentConfiguration(modelBuilder.Entity<Department>());
            new DocumentTypeConfiguration(modelBuilder.Entity<DocumentType>());
            new GenderConfiguration(modelBuilder.Entity<Gender>());
            new ModalityTypeConfiguration(modelBuilder.Entity<ModalityType>());
            new StudentConfiguration(modelBuilder.Entity<Student>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
