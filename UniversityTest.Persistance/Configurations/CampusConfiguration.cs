using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using UniversityTest.Domain.Models;

namespace UniversityTest.Persistance.Configurations
{
	public class CampusConfiguration
	{
		public CampusConfiguration(EntityTypeConfiguration<Campus> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
		}
	}
}
