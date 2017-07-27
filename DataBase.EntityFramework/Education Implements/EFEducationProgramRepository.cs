using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFEducationProgramRepository : EF_CRUD<EducationProgram>, IEducationProgramRepository
    {
        public EFEducationProgramRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
