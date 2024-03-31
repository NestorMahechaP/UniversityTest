using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CampusRepository : GenericRepository<Campus>, ICampusRepository
	{
		public CampusRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
