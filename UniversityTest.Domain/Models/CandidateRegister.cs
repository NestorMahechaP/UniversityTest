namespace UniversityTest.Domain.Models
{
	public class CandidateRegister
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public int CandidateTypeId { get; set; }
		public int ModalityTypeId { get; set; }
		public int CampusId { get; set; }
		public int AcademicProgramId { get; set; }
		public int AcademicPeriodId { get; set; }

		public Student Student { get; set; }
		public CandidateType CandidateType { get; set; }
		public ModalityType ModalityType { get; set; }
		public Campus Campus { get; set; }
		public AcademicProgram AcademicProgram { get; set; }
		public AcademicPeriod AcademicPeriod { get; set; }
	}
}
