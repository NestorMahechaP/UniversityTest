using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class BloodTypeRepository : GenericRepository<BloodType>, IBloodTypeRepository
	{
		public BloodTypeRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
