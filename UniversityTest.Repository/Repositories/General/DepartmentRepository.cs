using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
	{
		public DepartmentRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
