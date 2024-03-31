using System.Collections.Generic;

namespace UniversityTest.Domain.Models
{
	public class Country
	{
		public int Id { get; set; }
		public string Description { get; set; }

		public List<Student> Students { get; set; }
		public List<Student> ExpeditionStudents { get; set; }
	}
}
