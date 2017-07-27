using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFSubjectRepository : EF_CRUD<Subject>, ISubjectRepository
    {
        public EFSubjectRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
