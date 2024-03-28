using System;
using System.Collections.Generic;

namespace UniversityTest.Domain.Models
{
	public class Student
	{
		public int Id { get; set; }
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


		public Country Country { get; set; }
		public Department Department { get; set; }
		public City City { get; set; }
		public BloodType BloodType { get; set; }
		public DocumentType DocumentType { get; set; }
		public Country ExpeditionCountry { get; set; }
		public Department ExpeditionDepartment { get; set; }
		public City ExpeditionCity { get; set; }
		public Gender Gender { get; set; }
		public CivilStatus CivilStatus { get; set; }
		public List<CandidateRegister> CandidateRegisters { get; set; }
	}
}
