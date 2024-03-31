using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityTest.Domain.Dtos;
using UniversityTest.Repository.Interfaces;

namespace UniversityTest.Services.General
{
	public class StudentService : IStudentService
	{
		public IUnitOfWork _unitOfWork;

		public StudentService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<IEnumerable<ItemOption>> GetAllAcademicPeriods()
		{
			var result = (await _unitOfWork.AcademicPeriods.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllBloodTypes()
		{
			var result = (await _unitOfWork.BloodTypes.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllCampuses()
		{
			var result = (await _unitOfWork.Campuses.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllCandidateTypes()
		{
			var result = (await _unitOfWork.CandidateTypes.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllCities()
		{
			var result = (await _unitOfWork.Cities.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllCivilStatuses()
		{
			var result = (await _unitOfWork.CivilStatuses.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllCountries()
		{
			var result = (await _unitOfWork.Countries.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllDepartments()
		{
			var result = (await _unitOfWork.Departments.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllDocumentTypes()
		{
			var result = (await _unitOfWork.DocumentTypes.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllGenders()
		{
			var result = (await _unitOfWork.Genders.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllModalityTypes()
		{
			var result = (await _unitOfWork.ModalityTypes.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}

		public async Task<IEnumerable<ItemOption>> GetAllPrograms()
		{
			var result = (await _unitOfWork.AcademicPrograms.GetAll())
				.Select(x => new ItemOption()
				{
					Text = x.Description,
					Value = x.Id
				});
			return result;
		}
	}
}
