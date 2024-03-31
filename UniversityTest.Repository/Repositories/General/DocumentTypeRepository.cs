using UniversityTest.Domain.Models;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories.General
{
	public class DocumentTypeRepository : GenericRepository<DocumentType>, IDocumentTypeRepository
	{
		public DocumentTypeRepository(UniversityDbContext dbContext) : base(dbContext)
		{

		}
	}
}
