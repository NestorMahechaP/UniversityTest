using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class CandidateRegisterRepository : GenericRepository<CandidateRegister>, ICandidateRegisterRepository
	{
		public CandidateRegisterRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
