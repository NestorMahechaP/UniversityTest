using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class AcademicPeriodRepository : GenericRepository<AcademicPeriod>, IAcademicPeriodRepository
	{
		public AcademicPeriodRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
