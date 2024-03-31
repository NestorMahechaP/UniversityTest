using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CivilStatusRepository : GenericRepository<CivilStatus>, ICivilStatusRepository
	{
		public CivilStatusRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
