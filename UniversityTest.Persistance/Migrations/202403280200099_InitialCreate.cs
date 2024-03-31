namespace UniversityTest.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademicPeriods",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CandidateRegisters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CandidateTypeId = c.Int(nullable: false),
                        ModalityTypeId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        AcademicProgramId = c.Int(nullable: false),
                        AcademicPeriodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AcademicPeriods", t => t.AcademicPeriodId)
                .ForeignKey("dbo.AcademicPrograms", t => t.AcademicProgramId)
                .ForeignKey("dbo.Campus", t => t.CampusId)
                .ForeignKey("dbo.CandidateTypes", t => t.CandidateTypeId)
                .ForeignKey("dbo.ModalityTypes", t => t.ModalityTypeId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CandidateTypeId)
                .Index(t => t.ModalityTypeId)
                .Index(t => t.CampusId)
                .Index(t => t.AcademicProgramId)
                .Index(t => t.AcademicPeriodId);
            
            CreateTable(
                "dbo.AcademicPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CandidateTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModalityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        MiddleName = c.String(maxLength: 200),
                        SurName = c.String(nullable: false, maxLength: 200),
                        SecondSurName = c.String(nullable: false, maxLength: 200),
                        Telephone = c.String(maxLength: 20),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 200),
                        BirthDate = c.DateTime(nullable: false),
                        CountryId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        BloodTypeId = c.Int(nullable: false),
                        DocumentTypeId = c.Int(nullable: false),
                        DocumentNumber = c.String(nullable: false, maxLength: 50),
                        ExpeditionDate = c.DateTime(nullable: false),
                        ExpeditionCountryId = c.Int(nullable: false),
                        ExpeditionDepartmentId = c.Int(nullable: false),
                        ExpeditionCityId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        CivilStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodTypes", t => t.BloodTypeId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.CivilStatus", t => t.CivilStatusId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeId)
                .ForeignKey("dbo.Cities", t => t.ExpeditionCityId)
                .ForeignKey("dbo.Countries", t => t.ExpeditionCountryId)
                .ForeignKey("dbo.Departments", t => t.ExpeditionDepartmentId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .Index(t => t.CountryId)
                .Index(t => t.DepartmentId)
                .Index(t => t.CityId)
                .Index(t => t.BloodTypeId)
                .Index(t => t.DocumentTypeId)
                .Index(t => t.ExpeditionCountryId)
                .Index(t => t.ExpeditionDepartmentId)
                .Index(t => t.ExpeditionCityId)
                .Index(t => t.GenderId)
                .Index(t => t.CivilStatusId);
            
            CreateTable(
                "dbo.BloodTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CivilStatus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocumentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidateRegisters", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Students", "ExpeditionDepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "ExpeditionCountryId", "dbo.Countries");
            DropForeignKey("dbo.Students", "ExpeditionCityId", "dbo.Cities");
            DropForeignKey("dbo.Students", "DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Students", "CivilStatusId", "dbo.CivilStatus");
            DropForeignKey("dbo.Students", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Students", "BloodTypeId", "dbo.BloodTypes");
            DropForeignKey("dbo.CandidateRegisters", "ModalityTypeId", "dbo.ModalityTypes");
            DropForeignKey("dbo.CandidateRegisters", "CandidateTypeId", "dbo.CandidateTypes");
            DropForeignKey("dbo.CandidateRegisters", "CampusId", "dbo.Campus");
            DropForeignKey("dbo.CandidateRegisters", "AcademicProgramId", "dbo.AcademicPrograms");
            DropForeignKey("dbo.CandidateRegisters", "AcademicPeriodId", "dbo.AcademicPeriods");
            DropIndex("dbo.Students", new[] { "CivilStatusId" });
            DropIndex("dbo.Students", new[] { "GenderId" });
            DropIndex("dbo.Students", new[] { "ExpeditionCityId" });
            DropIndex("dbo.Students", new[] { "ExpeditionDepartmentId" });
            DropIndex("dbo.Students", new[] { "ExpeditionCountryId" });
            DropIndex("dbo.Students", new[] { "DocumentTypeId" });
            DropIndex("dbo.Students", new[] { "BloodTypeId" });
            DropIndex("dbo.Students", new[] { "CityId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "CountryId" });
            DropIndex("dbo.CandidateRegisters", new[] { "AcademicPeriodId" });
            DropIndex("dbo.CandidateRegisters", new[] { "AcademicProgramId" });
            DropIndex("dbo.CandidateRegisters", new[] { "CampusId" });
            DropIndex("dbo.CandidateRegisters", new[] { "ModalityTypeId" });
            DropIndex("dbo.CandidateRegisters", new[] { "CandidateTypeId" });
            DropIndex("dbo.CandidateRegisters", new[] { "StudentId" });
            DropTable("dbo.Genders");
            DropTable("dbo.DocumentTypes");
            DropTable("dbo.Departments");
            DropTable("dbo.Countries");
            DropTable("dbo.CivilStatus");
            DropTable("dbo.Cities");
            DropTable("dbo.BloodTypes");
            DropTable("dbo.Students");
            DropTable("dbo.ModalityTypes");
            DropTable("dbo.CandidateTypes");
            DropTable("dbo.Campus");
            DropTable("dbo.AcademicPrograms");
            DropTable("dbo.CandidateRegisters");
            DropTable("dbo.AcademicPeriods");
        }
    }
}
