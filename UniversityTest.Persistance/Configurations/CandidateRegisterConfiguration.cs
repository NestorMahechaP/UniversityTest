using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using UniversityTest.Domain.Models;

namespace UniversityTest.Persistance.Configurations
{
	public class CandidateRegisterConfiguration
	{
		public CandidateRegisterConfiguration(EntityTypeConfiguration<CandidateRegister> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			builder.Property(x => x.ModalityTypeId).IsRequired();
			builder.Property(x => x.StudentId).IsRequired();
			builder.Property(x => x.AcademicPeriodId).IsRequired();
			builder.Property(x => x.AcademicProgramId).IsRequired();
			builder.Property(x => x.CampusId).IsRequired();
			builder.Property(x => x.CandidateTypeId).IsRequired();

			builder.HasRequired(s => s.Student)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.StudentId);
			builder.HasRequired(s => s.AcademicProgram)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.AcademicProgramId);
			builder.HasRequired(s => s.Campus)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.CampusId);
			builder.HasRequired(s => s.CandidateType)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.CandidateTypeId);
			builder.HasRequired(s => s.ModalityType)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.ModalityTypeId);
			builder.HasRequired(s => s.AcademicPeriod)
				.WithMany(t => t.CandidateRegisters)
				.HasForeignKey(u => u.AcademicPeriodId);
		}
	}
}
