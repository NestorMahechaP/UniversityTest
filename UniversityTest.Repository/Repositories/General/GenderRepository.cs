using System.Threading.Tasks;
using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class GenderRepository : GenericRepository<Gender>, IGenderRepository
	{
		public GenderRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
