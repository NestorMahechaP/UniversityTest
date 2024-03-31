using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using UniversityTest.Domain.Models;

namespace UniversityTest.Persistance.Configurations
{
	public class StudentConfiguration
	{
		public StudentConfiguration(EntityTypeConfiguration<Student> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			builder.Property(x => x.BirthDate).IsRequired();
			builder.Property(x => x.DocumentNumber).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
			builder.Property(x => x.ExpeditionDate).IsRequired();
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.MiddleName).IsOptional().HasMaxLength(200);
			builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(20);
			builder.Property(x => x.SecondSurName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.SurName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.Telephone).IsOptional().HasMaxLength(20);

			builder.HasRequired(s => s.BloodType)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.BloodTypeId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.City)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.CityId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.CivilStatus)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.CivilStatusId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.Country)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.CountryId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.Department)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.DepartmentId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.DocumentType)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.DocumentTypeId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.ExpeditionCity)
				.WithMany(t => t.ExpeditionStudents)
				.HasForeignKey(u => u.ExpeditionCityId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.ExpeditionCountry)
				.WithMany(t => t.ExpeditionStudents)
				.HasForeignKey(u => u.ExpeditionCountryId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.ExpeditionDepartment)
				.WithMany(t => t.ExpeditionStudents)
				.HasForeignKey(u => u.ExpeditionDepartmentId)
				.WillCascadeOnDelete(false);

			builder.HasRequired(s => s.Gender)
				.WithMany(t => t.Students)
				.HasForeignKey(u => u.GenderId)
				.WillCascadeOnDelete(false);
		}
	}
}
