using System;
using System.Threading.Tasks;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces;
using UniversityTest.Repository.Interfaces.General;

namespace UniversityTest.Repository.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly UniversityDbContext _dbContext;
		public IAcademicPeriodRepository AcademicPeriods { get; }
		public IAcademicProgramRepository AcademicPrograms { get; }
		public IBloodTypeRepository BloodTypes { get; }
		public ICampusRepository Campuses { get; }
		public ICandidateRegisterRepository CandidateRegisters { get; }
		public ICandidateTypeRepository CandidateTypes { get; }
		public ICityRepository Cities { get; }
		public ICivilStatusRepository CivilStatuses { get; }
		public ICountryRepository Countries { get; }
		public IDepartmentRepository Departments { get; }
		public IDocumentTypeRepository DocumentTypes { get; }
		public IGenderRepository Genders { get; }
		public IModalityTypeRepository ModalityTypes { get; }
		public IStudentRepository Students { get; }

		public UnitOfWork(UniversityDbContext dbContext,
			IAcademicPeriodRepository academicPeriodRepository, IAcademicProgramRepository academicProgramRepository, IBloodTypeRepository bloodTypeRepository,
			ICampusRepository campusRepository, ICandidateRegisterRepository candidateRegisterRepository, ICandidateTypeRepository candidateTypeRepository,
			ICityRepository cityRepository, ICivilStatusRepository civilStatusRepository, ICountryRepository countryRepository,
			IDepartmentRepository departmentRepository, IDocumentTypeRepository documentTypeRepository, IGenderRepository genderRepository,
			IModalityTypeRepository modalityTypeRepository, IStudentRepository studentRepository)
		{
			_dbContext = dbContext;
			AcademicPeriods = academicPeriodRepository;
			AcademicPrograms = academicProgramRepository;
			BloodTypes = bloodTypeRepository;
			Campuses = campusRepository;
			CandidateRegisters = candidateRegisterRepository;
			CandidateTypes = candidateTypeRepository;
			Cities = cityRepository;
			CivilStatuses = civilStatusRepository;
			Countries = countryRepository;
			Departments = departmentRepository;
			DocumentTypes = documentTypeRepository;
			Genders = genderRepository;
			ModalityTypes = modalityTypeRepository;
			Students = studentRepository;
		}

		public Task<int> Save()
		{
			return _dbContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				_dbContext.Dispose();
			}
		}
	}
}
