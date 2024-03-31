using System;
using System.Threading.Tasks;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IAcademicPeriodRepository AcademicPeriods { get; }
		IAcademicProgramRepository AcademicPrograms { get; }
		IBloodTypeRepository BloodTypes { get; }
		ICampusRepository Campuses { get; }
		ICandidateRegisterRepository CandidateRegisters { get; }
		ICandidateTypeRepository CandidateTypes { get; }
		ICityRepository Cities { get; }
		ICivilStatusRepository CivilStatuses { get; }
		ICountryRepository Countries { get; }
		IDepartmentRepository Departments { get; }
		IDocumentTypeRepository DocumentTypes { get; }
		IGenderRepository Genders { get; }
		IModalityTypeRepository ModalityTypes { get; }
		IStudentRepository Students { get; }
		Task<int> Save();
	}
}
