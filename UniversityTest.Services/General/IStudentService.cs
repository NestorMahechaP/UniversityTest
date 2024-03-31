using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityTest.Domain.Dtos;

namespace UniversityTest.Services.General
{
	public interface IStudentService
	{
		Task<IEnumerable<ItemOption>> GetAllGenders();
		Task<IEnumerable<ItemOption>> GetAllModalityTypes();
		Task<IEnumerable<ItemOption>> GetAllCampuses();
		Task<IEnumerable<ItemOption>> GetAllPrograms();
		Task<IEnumerable<ItemOption>> GetAllAcademicPeriods();
		Task<IEnumerable<ItemOption>> GetAllDepartments();
		Task<IEnumerable<ItemOption>> GetAllCountries();
		Task<IEnumerable<ItemOption>> GetAllCities();
		Task<IEnumerable<ItemOption>> GetAllDocumentTypes();
		Task<IEnumerable<ItemOption>> GetAllCivilStatuses();
		Task<IEnumerable<ItemOption>> GetAllCandidateTypes();
		Task<IEnumerable<ItemOption>> GetAllBloodTypes();
	}
}
