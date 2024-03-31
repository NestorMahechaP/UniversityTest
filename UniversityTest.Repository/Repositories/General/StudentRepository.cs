using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class StudentRepository : GenericRepository<Student>, IStudentRepository
	{
		public StudentRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
