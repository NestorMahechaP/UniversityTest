using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class AcademicProgramRepository : GenericRepository<AcademicProgram>, IAcademicProgramRepository
	{
		public AcademicProgramRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
