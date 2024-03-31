using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CandidateTypeRepository : GenericRepository<CandidateType>, ICandidateTypeRepository
	{
		public CandidateTypeRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
