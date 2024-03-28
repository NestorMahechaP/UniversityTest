using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using UniversityTest.Domain.Models;

namespace UniversityTest.Persistance.Configurations
{
	public class AcademicPeriodConfiguration
	{
		public AcademicPeriodConfiguration(EntityTypeConfiguration<AcademicPeriod> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
		}
	}
}
