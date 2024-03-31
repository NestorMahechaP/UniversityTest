using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UniversityTest.Repository.Interfaces;
using UniversityTest.Repository.Interfaces.General;
using UniversityTest.Repository.Repositories;
using UniversityTest.Repository.Repositories.General;
using UniversityTest.Services.General;

namespace UniversityTest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IAcademicPeriodRepository, AcademicPeriodRepository>();
            container.RegisterType<IAcademicProgramRepository, AcademicProgramRepository>();
            container.RegisterType<IBloodTypeRepository, BloodTypeRepository>();
            container.RegisterType<ICampusRepository, CampusRepository>();
            container.RegisterType<ICandidateRegisterRepository, CandidateRegisterRepository>();
            container.RegisterType<ICandidateTypeRepository, CandidateTypeRepository>();
            container.RegisterType<ICityRepository, CityRepository>();
            container.RegisterType<ICivilStatusRepository, CivilStatusRepository>();
            container.RegisterType<ICountryRepository, CountryRepository>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IDocumentTypeRepository, DocumentTypeRepository>();
            container.RegisterType<IGenderRepository, GenderRepository>();
            container.RegisterType<IModalityTypeRepository, ModalityTypeRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}