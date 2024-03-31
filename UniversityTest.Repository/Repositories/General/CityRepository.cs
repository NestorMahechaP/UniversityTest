using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CityRepository : GenericRepository<City>, ICityRepository
	{
		public CityRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
