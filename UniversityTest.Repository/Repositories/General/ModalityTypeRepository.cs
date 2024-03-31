using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class ModalityTypeRepository : GenericRepository<ModalityType>, IModalityTypeRepository
	{
		public ModalityTypeRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
