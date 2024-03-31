using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CountryRepository : GenericRepository<Country>, ICountryRepository
	{
		public CountryRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
