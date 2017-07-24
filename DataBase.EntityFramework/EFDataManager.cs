using System;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFDataManager : IDataManager
    {
        public ICategoryRepository Categories => throw new NotImplementedException();

        public IEducationalPlanRepository EducationalPlans => throw new NotImplementedException();

        public IEducationTypeRepository EducationTypes => throw new NotImplementedException();

        public IGroupRepository Groups => throw new NotImplementedException();

        public IEducationProgramRepository EducationPrograms => throw new NotImplementedException();

        public IExamRepository Exams => throw new NotImplementedException();

        public IExamCommentRepository ExamComments => throw new NotImplementedException();

        public IStatementRepository Statements => throw new NotImplementedException();

        public ISubGroupRepository SubGroups => throw new NotImplementedException();

        public ISubjectRepository Subjects => throw new NotImplementedException();

        public ICertificationRepository Certification => throw new NotImplementedException();

        public ICertificationTypeRepository CertificationTypes => throw new NotImplementedException();

        public IUserRepository Users => throw new NotImplementedException();

        public IUserCardRepository UserCards => throw new NotImplementedException();

        public IUserCommentRepository UserComments => throw new NotImplementedException();

        public IUserContractRepository UserContracts => throw new NotImplementedException();

        public IUserLocationRepository UserLocations => throw new NotImplementedException();

        public IUserPhotoRepository UserPhotos => throw new NotImplementedException();

        public IUserProfileRepository UserProfiles => throw new NotImplementedException();
    }
}
