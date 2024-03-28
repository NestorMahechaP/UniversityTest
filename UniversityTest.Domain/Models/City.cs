using System.Collections.Generic;

namespace UniversityTest.Domain.Models
{
	public class City
	{
		public int Id { get; set; }
		public string Description { get; set; }

		public List<Student> Students { get; set; }
	}
}
