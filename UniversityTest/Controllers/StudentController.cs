using System.Threading.Tasks;
using System.Web.Mvc;
using UniversityTest.Services.General;

namespace UniversityTest.Controllers
{
	public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: Student
        public async Task<ActionResult> Index()
        {
            ViewBag.ModalityTypes = await _studentService.GetAllModalityTypes();
            ViewBag.Genders = await _studentService.GetAllGenders();
            ViewBag.Campuses = await _studentService.GetAllCampuses();
            ViewBag.Programs = await _studentService.GetAllPrograms();
            ViewBag.Periods = await _studentService.GetAllAcademicPeriods();
            ViewBag.Departments = await _studentService.GetAllDepartments();
            ViewBag.Countries = await _studentService.GetAllCountries();
            ViewBag.Cities = await _studentService.GetAllCities();
            ViewBag.DocumentTypes = await _studentService.GetAllDocumentTypes();
            ViewBag.CivilStatuses = await _studentService.GetAllCivilStatuses();
            ViewBag.CandidateTypes = await _studentService.GetAllCandidateTypes();
            ViewBag.BloodTypes = await _studentService.GetAllBloodTypes();
            return View();
        }
    }
}