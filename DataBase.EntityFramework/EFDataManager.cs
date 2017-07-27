using System;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFDataManager : IDataManager
    {
        private ApplicationContext db;

        EFCategoryRepository Category;
        EFEducationalPlanRepository EducationPlan;
        EFEducationTypeRepository EducationType;
        EFGroupRepository Group;
        EFEducationProgramRepository EducationProgram;
        EFExamRepository Exam;
        EFExamCommentsRepository ExamComment;
        EFStatementRepository Statement;
        EFSubGroupRepository SubGroup;
        EFSubjectRepository Subject;
        EFCertificationRepository Certification;
        EFCertificationTypeRepository CertificationType;

        EFUserRepository User;
        EFUserCardRepository UserCard;
        EFUserCommentsRepository UserComment;
        EFUserContractRepository UserContract;
        EFUserLocationRepository UserLocation;
        EFUserPhotoRepository UserPhoto;
        EFUserProfileRepository UserProfile;

        public EFDataManager(ApplicationContext context)
        {
            db = context;
        }

        public ICategoryRepository Categories => Category ?? (Category = new EFCategoryRepository(db));

        public IEducationalPlanRepository EducationalPlans => EducationPlan ?? (EducationPlan = new EFEducationalPlanRepository(db));

        public IEducationTypeRepository EducationTypes => EducationType ?? (EducationType = new EFEducationTypeRepository(db));

        public IGroupRepository Groups => Group ?? (Group = new EFGroupRepository(db));

        public IEducationProgramRepository EducationPrograms => EducationProgram ?? (EducationProgram = new EFEducationProgramRepository(db));

        public IExamRepository Exams => Exam ?? (Exam = new EFExamRepository(db));

        public IExamCommentRepository ExamComments => ExamComment ?? (ExamComment = new EFExamCommentsRepository(db));

        public IStatementRepository Statements => Statement ?? (Statement = new EFStatementRepository(db));

        public ISubGroupRepository SubGroups => SubGroup ?? (SubGroup = new EFSubGroupRepository(db));

        public ISubjectRepository Subjects => Subject ?? (Subject = new EFSubjectRepository(db));

        public ICertificationRepository Certifications => Certification ?? (Certification = new EFCertificationRepository(db));

        public ICertificationTypeRepository CertificationTypes => CertificationType ?? (CertificationType = new EFCertificationTypeRepository(db));


        public IUserRepository Users => User ?? (User = new EFUserRepository(db));

        public IUserCardRepository UserCards => UserCard ?? (UserCard = new EFUserCardRepository(db));

        public IUserCommentRepository UserComments => UserComment ?? (UserComment = new EFUserCommentsRepository(db));

        public IUserContractRepository UserContracts => UserContract ?? (UserContract = new EFUserContractRepository(db));

        public IUserLocationRepository UserLocations => UserLocation ?? (UserLocation = new EFUserLocationRepository(db));

        public IUserPhotoRepository UserPhotos => UserPhoto ?? (UserPhoto = new EFUserPhotoRepository(db));

        public IUserProfileRepository UserProfiles => UserProfile ?? (UserProfile = new EFUserProfileRepository(db));


        public void Save()
        {
            db.SaveChanges();
        }


        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
