using System.Collections.Generic;

namespace UniversityTest.Domain.Models
{
	public class Campus
	{
		public int Id { get; set; }
		public string Description { get; set; }

		public List<CandidateRegister> CandidateRegisters { get; set; }
	}
}
