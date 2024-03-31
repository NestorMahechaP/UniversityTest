using System;

namespace UniversityTest.Domain.Dtos
{
	public class StudentDto
	{
		public int CandidateType { get; set; }
		public int ModalityType { get; set; }
		public int Campus { get; set; }
		public int AcademicPeriod { get; set; }
		public int Program { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string SurName { get; set; }
		public string SecondSurName { get; set; }
		public string Telephone { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }
		public int CountryId { get; set; }
		public int DepartmentId { get; set; }
		public int CityId { get; set; }
		public int BloodTypeId { get; set; }
		public int DocumentTypeId { get; set; }
		public string DocumentNumber { get; set; }
		public DateTime ExpeditionDate { get; set; }
		public int ExpeditionCountryId { get; set; }
		public int ExpeditionDepartmentId { get; set; }
		public int ExpeditionCityId { get; set; }
		public int GenderId { get; set; }
		public int CivilStatusId { get; set; }
	}
}
