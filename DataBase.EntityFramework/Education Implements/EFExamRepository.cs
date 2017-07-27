using System;
using System.Collections.Generic;
using Domain.Core.Education;
using Domain.Interfaces.Repositories;

namespace DataBase.EntityFramework
{
    public class EFExamRepository : EF_CRUD<Exam>, IExamRepository
    {
        public EFExamRepository(ApplicationContext db) : base(db)
        {
        }
    }
}
